using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Hotel {
    public partial class GuestDialog : Form {
        public Person CurrentGuest { get; set; }
        public Person NewGuest { get; set; }
        public List<string> AvailableRooms { get; set; }
        private bool isEdit = false;
        private string firstName;
        private string lastName;
        private string roomNumber;
        private string numOfNights;
        private string resDate;
        private string errorMsg;

        /// <summary>
        /// Constructor used to add a guest
        /// </summary>
        public GuestDialog() {
            InitializeComponent();
            addBtn.Enabled = false;
            editBtn.Visible = false;
            cancelBtn.DialogResult = DialogResult.Cancel;
            addBtn.DialogResult = DialogResult.Yes;
            reservationDateBox.MinDate = DateTime.Now;
            SetEventHandlers();
        }

        /// <summary>
        /// Constructor used for editing a guest's information
        /// </summary>
        /// <param name="p">The guest to be edited</param>
        public GuestDialog(Person p) {
            InitializeComponent();
            CurrentGuest = p;
            isEdit = true;
            this.Text = "Edit Guest";
            this.firstName = p.FirstName;
            this.lastName = p.LastName;
            this.roomNumber = p.RoomNumber.ToString();
            this.numOfNights = p.NumberOfNights.ToString();
            this.resDate = p.ReservationDate.ToString();

            // Fill textboxes with the current guest's information
            firstNameBox.Text = this.firstName;
            lastNameBox.Text = this.lastName;
            roomNumberBox.Text = this.roomNumber;
            numOfNightsBox.Text = this.numOfNights;
            reservationDateBox.Text = this.resDate;

            addBtn.Enabled = false;
            addBtn.Visible = false;
            editBtn.Enabled = false;
            editBtn.Visible = true;
            cancelBtn.DialogResult = DialogResult.Cancel;
            editBtn.DialogResult = DialogResult.Yes;
            SetEventHandlers();
        }

        private void CancelBtn_Click(object sender, EventArgs e) {
            this.Dispose();
        }

        private void addBtn_Click(object sender, EventArgs e) {
            NewGuest = new Person(firstName, lastName, int.Parse(roomNumber), int.Parse(numOfNights), resDate);
        }

        private void editBtn_Click(object sender, EventArgs e) {
            NewGuest = new Person(firstName, lastName, int.Parse(roomNumber), int.Parse(numOfNights), resDate);
        }

        private bool FormIsValid() {
            errorMsg = "";
            firstName = firstNameBox.Text.Trim();
            lastName = lastNameBox.Text.Trim();
            roomNumber = roomNumberBox.Text.Trim();
            numOfNights = numOfNightsBox.Text.Trim();
            resDate = reservationDateBox.Text.Trim();

            // Validate first name: all letters, one word
            if (!firstName.Any()) {
                errorMsg += "First Name should not be empty\n";
            }
            else {
                if (!firstName.All(c => Char.IsLetter(c))) {
                    errorMsg += "First Name should only contain letters\n";
                }
                if (firstName.Split(' ').Length != 1) {
                    errorMsg += "First Name should only be one word\n";
                }
            }

            // Validate last name: all letters, one word
            if (!lastName.Any()) {
                errorMsg += "Last Name should not be empty\n";
            }
            else {
                if (!lastName.All(c => Char.IsLetter(c))) {
                    errorMsg += "Last Name should only contain letters\n";
                }
                if (lastName.Split(' ').Length != 1) {
                    errorMsg += "Last Name should only be one word\n";
                }
            }

            // Validate room number: all numbers, one number, room number is available
            if (!roomNumber.Any()) {
                errorMsg += "Room Number should not be empty\n";
            }
            else {
                if (!roomNumber.All(c => Char.IsDigit(c))) {
                    errorMsg += "Room Number should only contain numbers\n";
                }
                if (roomNumber.Split(' ').Length != 1) {
                    errorMsg += "Room Number should only be one word\n";
                }
                if (!AvailableRooms.Contains(roomNumber)) {
                    if(isEdit) {
                        if (!CurrentGuest.RoomNumber.ToString().Equals(roomNumber)) {
                            errorMsg += "The room number entered is not available\n";
                        }
                    }
                    else {
                        errorMsg += "The room number entered is not available\n";
                    }
                }
            }

            // Validate number of nights: all numbers , one number
            if (!numOfNights.Any()) {
                errorMsg += "Number of Nights should not be empty\n";
            }
            else {
                if (!numOfNights.All(c => Char.IsDigit(c))) {
                    errorMsg += "Number of Nights should only contain numbers\n";
                }
                else {
                    if (int.Parse(numOfNights) <= 0) {
                        errorMsg += "Number of Nights should be at least 1\n";
                    }
                }
                if (numOfNights.Split(' ').Length != 1) {
                    errorMsg += "Number of Nights should only be one word\n";
                }
            }

            return errorMsg.Equals("");
        }

        /********** EVENT HANDLERS **********/

        private void TextBoxTextChanged(object sender, EventArgs e) {
            if (FormIsValid()) {
                infoLabel.Text = "";
                if (isEdit) {
                    editBtn.Enabled = true;
                }
                else { addBtn.Enabled = true; }
            }
            else {
                infoLabel.Text = errorMsg;
                addBtn.Enabled = false;
                editBtn.Enabled = false;
            }
        }


        /********** HELPER METHODS *********/

        private void SetEventHandlers() {
            firstNameBox.TextChanged += TextBoxTextChanged;
            lastNameBox.TextChanged += TextBoxTextChanged;
            roomNumberBox.TextChanged += TextBoxTextChanged;
            numOfNightsBox.TextChanged += TextBoxTextChanged;
        }

        
    }
}
