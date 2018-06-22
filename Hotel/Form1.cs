using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel {
    public partial class Form1 : Form {
        private string connectionString;
        private MySqlDataAdapter roomsAdapter;
        private MySqlDataAdapter guestAdapter;
        private DataSet hotelDataSet;
        private DataGridViewButtonColumn buttonCol;
        private string roomDataTableString = "RoomData";
        private string guestDataTableString = "GuestData";


        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            connectionString = "server=localhost;uid=root;database=hotel;password=Sodacan5100";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            hotelDataSet = new DataSet();

            

            // Initialize the rooms Data Adapter
            roomsAdapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT room_number, price, number_of_beds, room_status, room_type FROM rooms", conn);

            // Create the UpdateCommand for roomsAdapter
            MySqlCommand cmd = new MySqlCommand("UPDATE rooms SET room_status = @RoomStatus WHERE room_number = @RoomNumber", conn);
            cmd.Parameters.Add("@RoomStatus", MySqlDbType.VarChar, 10, "room_status");
            cmd.Parameters.Add("@RoomNumber", MySqlDbType.Int32, 11, "room_number");
            roomsAdapter.SelectCommand = command;
            roomsAdapter.UpdateCommand = cmd;
            roomsAdapter.Fill(hotelDataSet, roomDataTableString);
            roomTable.DataSource = hotelDataSet.Tables[roomDataTableString];


            // Intialize the guests Data Adapter
            guestAdapter = new MySqlDataAdapter();
            guestAdapter.SelectCommand = new MySqlCommand("SELECT first_name, last_name, room_number, number_of_nights, reservation_date FROM guests", conn);

            // Create the UpdateCommand for guestAdapter
            cmd = new MySqlCommand("UPDATE guests SET first_name = @FirstName, last_name = @LastName, room_number = @RoomNumber, number_of_nights = @NumberOfNights, reservation_date = @ReservationDate WHERE room_number = @OldRoomNumber", conn);
            cmd.Parameters.Add("@FirstName", MySqlDbType.VarChar, 45, "first_name");
            cmd.Parameters.Add("@LastName", MySqlDbType.VarChar, 45, "last_name");
            cmd.Parameters.Add("@RoomNumber", MySqlDbType.Int32, 11, "room_number");
            cmd.Parameters.Add("@NumberOfNights", MySqlDbType.Int32, 11, "number_of_nights");
            cmd.Parameters.Add("@ReservationDate", MySqlDbType.VarChar, 10, "reservation_date");
            MySqlParameter param = cmd.Parameters.Add("@OldRoomNumber", MySqlDbType.Int32, 11, "room_number");
            param.SourceVersion = DataRowVersion.Original;
            guestAdapter.UpdateCommand = cmd;

            // Create the InsertCommand for guestAdapter
            cmd = new MySqlCommand("INSERT INTO guests (first_name, last_name, room_number, number_of_nights, reservation_date) VALUES (@FirstName, @LastName, @RoomNumber, @NumberOfNights, @ReservationDate)", conn);
            cmd.Parameters.Add("@FirstName", MySqlDbType.VarChar, 45, "first_name");
            cmd.Parameters.Add("@LastName", MySqlDbType.VarChar, 45, "last_name");
            cmd.Parameters.Add("@RoomNumber", MySqlDbType.Int32, 11, "room_number");
            cmd.Parameters.Add("@NumberOfNights", MySqlDbType.Int32, 11, "number_of_nights");
            cmd.Parameters.Add("@ReservationDate", MySqlDbType.VarChar, 10, "reservation_date");
            guestAdapter.InsertCommand = cmd;

            // Create the DeleteCommand for guestAdapter
            cmd = new MySqlCommand("DELETE FROM guests WHERE room_number = ?", conn);
            param = cmd.Parameters.Add("room_number", MySqlDbType.Int32, 11, "room_number");
            param.SourceVersion = DataRowVersion.Original;
            guestAdapter.DeleteCommand = cmd;

            guestAdapter.Fill(hotelDataSet, guestDataTableString);
            guestTable.DataSource = hotelDataSet.Tables[guestDataTableString];
            buttonCol = new DataGridViewButtonColumn();
            buttonCol.Text = "Checkout";
            buttonCol.UseColumnTextForButtonValue = true;
            guestTable.Columns.Add(buttonCol);

            conn.Dispose();
        }

        /// <summary>
        /// Event handler used to checkout a guest
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guestTable_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == 5) {
                // Get the room number
                string roomNumber = guestTable.Rows[e.RowIndex].Cells[2].Value.ToString();
                // Delete the row from the hotelDataSet
                hotelDataSet.Tables[guestDataTableString].Rows[e.RowIndex].Delete();
                // Set the room status to "Available"
                hotelDataSet.Tables[roomDataTableString].Rows.Cast<DataRow>().ToList().ForEach(r => {
                    if (r.Field<int>(0) == int.Parse(roomNumber)) {
                        r.SetField<string>(3, "Available");
                    }
                });
                guestAdapter.Update(hotelDataSet, guestDataTableString);
                roomsAdapter.Update(hotelDataSet, roomDataTableString);
            }
        }

        /// <summary>
        /// Opens a dialog window to add a guest
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addGuestBtn_Click(object sender, EventArgs e) {
            List<string> availableRooms = GetAvailableRooms();
            GuestDialog dialog = new GuestDialog();
            dialog.AvailableRooms = availableRooms;
            if (dialog.ShowDialog(this) == DialogResult.Yes) {
                Person guest = dialog.NewGuest;
                dialog.Dispose();
                // Update the room status in hotelDataSet
                hotelDataSet.Tables[roomDataTableString].Rows.Cast<DataRow>().ToList().ForEach(r => { if (r.Field<int>(0) == guest.RoomNumber) { r.SetField<string>(3, "Booked"); } });
                // Insert new guest into hotelDataSet
                hotelDataSet.Tables[guestDataTableString].Rows.Add(guest.FirstName, guest.LastName, guest.RoomNumber, guest.NumberOfNights, guest.ReservationDate);
                // Update the DataSet
                roomsAdapter.Update(hotelDataSet, roomDataTableString);
                guestAdapter.Update(hotelDataSet, guestDataTableString);
            }

        }

        /// <summary>
        /// Opens a dialog window to edit a guest's information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editGuestBtn_Click(object sender, EventArgs e) {
            if (guestTable.SelectedRows.Count == 0) {
                MessageBox.Show("Please select a row from the guest table");
                return;
            }

            List<string> availableRooms = GetAvailableRooms();
            DataRow row = hotelDataSet.Tables[guestDataTableString].Rows[guestTable.SelectedRows[0].Index];
            Person currentGuest = new Person(row.Field<string>(0), row.Field<string>(1), row.Field<int>(2), row.Field<int>(3), row.Field<string>(4));
            GuestDialog dialog = new GuestDialog(currentGuest);
            dialog.AvailableRooms = availableRooms;
            if (dialog.ShowDialog(this) == DialogResult.Yes) {
                Person editedGuest = dialog.NewGuest;
                dialog.Dispose();
                if(currentGuest.Equals(editedGuest)) {
                    return;
                }
                
                MySqlConnection conn = new MySqlConnection(connectionString);

                /***** CHECKS FOR EDITED GUEST *****/

                // Check if the guest's first name was changed
                if (!currentGuest.FirstName.Equals(editedGuest.FirstName)) {
                    hotelDataSet.Tables[guestDataTableString].Rows.Cast<DataRow>().ToList().ForEach(r => {
                        if (r.Field<int>(2) == currentGuest.RoomNumber) {
                            r.SetField<string>(0, editedGuest.FirstName);
                        }
                    });
                }

                // Check if the guest's last name was changed
                if (!currentGuest.LastName.Equals(editedGuest.LastName)) {
                    hotelDataSet.Tables[guestDataTableString].Rows.Cast<DataRow>().ToList().ForEach(r => {
                        if (r.Field<int>(2) == currentGuest.RoomNumber) {
                            r.SetField<string>(1, editedGuest.LastName);
                        }
                    });
                }

                // Check if the guest's room number was changed
                if (currentGuest.RoomNumber != editedGuest.RoomNumber) {
                    // Change the guest's room number
                    hotelDataSet.Tables[guestDataTableString].Rows.Cast<DataRow>().ToList().ForEach(r => {
                        if (r.Field<int>(2) == currentGuest.RoomNumber) {
                            r.SetField<int>(2, editedGuest.RoomNumber);
                        }
                    });
                    // Update the room status in hotelDataSet
                    // Make old room available
                    hotelDataSet.Tables[roomDataTableString].Rows.Cast<DataRow>().ToList().ForEach(r => {
                        if (r.Field<int>(0) == currentGuest.RoomNumber) {
                            r.SetField<string>(3, "Available");
                        }
                    });
                    // Make new room unavailable
                    hotelDataSet.Tables[roomDataTableString].Rows.Cast<DataRow>().ToList().ForEach(r => {
                        if (r.Field<int>(0) == editedGuest.RoomNumber) {
                            r.SetField<string>(3, "Booked");
                        }
                    });
                }

                // Check if the guest's number of nights was changed
                if (currentGuest.NumberOfNights != editedGuest.NumberOfNights) {
                    hotelDataSet.Tables[guestDataTableString].Rows.Cast<DataRow>().ToList().ForEach(r => {
                        if (r.Field<int>(2) == currentGuest.RoomNumber) {
                            r.SetField<int>(3, editedGuest.NumberOfNights);
                        }
                    });
                }

                // Check if the guest's reservation date was changed
                if (!currentGuest.ReservationDate.Equals(editedGuest.ReservationDate)) {
                    hotelDataSet.Tables[guestDataTableString].Rows.Cast<DataRow>().ToList().ForEach(r => {
                        if (r.Field<int>(2) == currentGuest.RoomNumber) {
                            r.SetField<string>(4, editedGuest.ReservationDate);
                        }  
                    });
                }

                
                roomsAdapter.Update(hotelDataSet, roomDataTableString);
                guestAdapter.Update(hotelDataSet, guestDataTableString);
            }
        }


        /********** HELPER METHODS **********/

        private List<string> GetAvailableRooms() {
            List<string> availableRooms = new List<string>();
            roomTable.Rows.Cast<DataGridViewRow>().ToList().ForEach(r => {
                if (r.Cells[3].Value.ToString().Equals("Available")) {
                    availableRooms.Add(r.Cells[0].Value.ToString());
                }
            });
            return availableRooms;
        }

        
    }
}
