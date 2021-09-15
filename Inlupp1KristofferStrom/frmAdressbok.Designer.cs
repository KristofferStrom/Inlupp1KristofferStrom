
namespace Inlupp1KristofferStrom
{
    partial class frmAdressbok
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCreateNewContact = new System.Windows.Forms.Button();
            this.listBoxContacts = new System.Windows.Forms.ListBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelContactEmail = new System.Windows.Forms.Label();
            this.labelContactPostalCode = new System.Windows.Forms.Label();
            this.labelContactPhoneNumber = new System.Windows.Forms.Label();
            this.labelContactStreetAddress = new System.Windows.Forms.Label();
            this.labelContactCity = new System.Windows.Forms.Label();
            this.labelContactName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.labelStreetAddress = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxStreetAddress = new System.Windows.Forms.TextBox();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.labelContactId = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreateNewContact
            // 
            this.buttonCreateNewContact.Location = new System.Drawing.Point(93, 515);
            this.buttonCreateNewContact.Name = "buttonCreateNewContact";
            this.buttonCreateNewContact.Size = new System.Drawing.Size(329, 43);
            this.buttonCreateNewContact.TabIndex = 16;
            this.buttonCreateNewContact.Text = "Registrera ny";
            this.buttonCreateNewContact.UseVisualStyleBackColor = true;
            this.buttonCreateNewContact.Click += new System.EventHandler(this.buttonCreateNewContact_Click);
            // 
            // listBoxContacts
            // 
            this.listBoxContacts.FormattingEnabled = true;
            this.listBoxContacts.ItemHeight = 20;
            this.listBoxContacts.Location = new System.Drawing.Point(93, 123);
            this.listBoxContacts.Name = "listBoxContacts";
            this.listBoxContacts.Size = new System.Drawing.Size(329, 364);
            this.listBoxContacts.TabIndex = 15;
            this.listBoxContacts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxContacts_MouseClick);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(369, 76);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(53, 27);
            this.buttonSearch.TabIndex = 14;
            this.buttonSearch.Text = "SÖK";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(93, 76);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(257, 27);
            this.textBoxSearch.TabIndex = 13;
            // 
            // labelContactEmail
            // 
            this.labelContactEmail.AutoSize = true;
            this.labelContactEmail.Location = new System.Drawing.Point(751, 321);
            this.labelContactEmail.Name = "labelContactEmail";
            this.labelContactEmail.Size = new System.Drawing.Size(50, 20);
            this.labelContactEmail.TabIndex = 62;
            this.labelContactEmail.Text = "label6";
            // 
            // labelContactPostalCode
            // 
            this.labelContactPostalCode.AutoSize = true;
            this.labelContactPostalCode.Location = new System.Drawing.Point(751, 236);
            this.labelContactPostalCode.Name = "labelContactPostalCode";
            this.labelContactPostalCode.Size = new System.Drawing.Size(50, 20);
            this.labelContactPostalCode.TabIndex = 61;
            this.labelContactPostalCode.Text = "label5";
            // 
            // labelContactPhoneNumber
            // 
            this.labelContactPhoneNumber.AutoSize = true;
            this.labelContactPhoneNumber.Location = new System.Drawing.Point(751, 278);
            this.labelContactPhoneNumber.Name = "labelContactPhoneNumber";
            this.labelContactPhoneNumber.Size = new System.Drawing.Size(50, 20);
            this.labelContactPhoneNumber.TabIndex = 60;
            this.labelContactPhoneNumber.Text = "label4";
            // 
            // labelContactStreetAddress
            // 
            this.labelContactStreetAddress.AutoSize = true;
            this.labelContactStreetAddress.Location = new System.Drawing.Point(752, 159);
            this.labelContactStreetAddress.Name = "labelContactStreetAddress";
            this.labelContactStreetAddress.Size = new System.Drawing.Size(50, 20);
            this.labelContactStreetAddress.TabIndex = 59;
            this.labelContactStreetAddress.Text = "label3";
            // 
            // labelContactCity
            // 
            this.labelContactCity.AutoSize = true;
            this.labelContactCity.Location = new System.Drawing.Point(752, 196);
            this.labelContactCity.Name = "labelContactCity";
            this.labelContactCity.Size = new System.Drawing.Size(50, 20);
            this.labelContactCity.TabIndex = 58;
            this.labelContactCity.Text = "label2";
            // 
            // labelContactName
            // 
            this.labelContactName.AutoSize = true;
            this.labelContactName.Location = new System.Drawing.Point(751, 123);
            this.labelContactName.Name = "labelContactName";
            this.labelContactName.Size = new System.Drawing.Size(50, 20);
            this.labelContactName.TabIndex = 57;
            this.labelContactName.Text = "label1";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(648, 321);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(52, 20);
            this.labelEmail.TabIndex = 56;
            this.labelEmail.Text = "E-post";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(642, 278);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(58, 20);
            this.labelPhoneNumber.TabIndex = 55;
            this.labelPhoneNumber.Text = "Telefon";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(645, 196);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(55, 20);
            this.labelCity.TabIndex = 54;
            this.labelCity.Text = "Postort";
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Location = new System.Drawing.Point(609, 236);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(91, 20);
            this.labelPostalCode.TabIndex = 53;
            this.labelPostalCode.Text = "Postnummer";
            // 
            // labelStreetAddress
            // 
            this.labelStreetAddress.AutoSize = true;
            this.labelStreetAddress.Location = new System.Drawing.Point(618, 159);
            this.labelStreetAddress.Name = "labelStreetAddress";
            this.labelStreetAddress.Size = new System.Drawing.Size(82, 20);
            this.labelStreetAddress.TabIndex = 52;
            this.labelStreetAddress.Text = "Gatuadress";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(651, 123);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 20);
            this.labelName.TabIndex = 51;
            this.labelName.Text = "Namn";
            // 
            // textBoxStreetAddress
            // 
            this.textBoxStreetAddress.Location = new System.Drawing.Point(751, 156);
            this.textBoxStreetAddress.Name = "textBoxStreetAddress";
            this.textBoxStreetAddress.Size = new System.Drawing.Size(323, 27);
            this.textBoxStreetAddress.TabIndex = 50;
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Location = new System.Drawing.Point(751, 233);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(322, 27);
            this.textBoxPostalCode.TabIndex = 49;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(751, 318);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(322, 27);
            this.textBoxEmail.TabIndex = 48;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(751, 275);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(322, 27);
            this.textBoxPhoneNumber.TabIndex = 47;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(751, 193);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(322, 27);
            this.textBoxCity.TabIndex = 46;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(752, 120);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(322, 27);
            this.textBoxName.TabIndex = 45;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Location = new System.Drawing.Point(938, 517);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(135, 38);
            this.buttonSaveChanges.TabIndex = 63;
            this.buttonSaveChanges.Text = "Spara ändringar";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(951, 517);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(122, 38);
            this.buttonEdit.TabIndex = 64;
            this.buttonEdit.Text = "Ändra";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAbort
            // 
            this.buttonAbort.Location = new System.Drawing.Point(784, 517);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(135, 38);
            this.buttonAbort.TabIndex = 65;
            this.buttonAbort.Text = "Avbryt";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // labelContactId
            // 
            this.labelContactId.AutoSize = true;
            this.labelContactId.Location = new System.Drawing.Point(752, 77);
            this.labelContactId.Name = "labelContactId";
            this.labelContactId.Size = new System.Drawing.Size(22, 20);
            this.labelContactId.TabIndex = 66;
            this.labelContactId.Text = "Id";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(797, 517);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(122, 38);
            this.buttonDelete.TabIndex = 67;
            this.buttonDelete.Text = "Ta bort";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // frmAdressbok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 613);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelContactId);
            this.Controls.Add(this.buttonAbort);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.labelContactEmail);
            this.Controls.Add(this.labelContactPostalCode);
            this.Controls.Add(this.labelContactPhoneNumber);
            this.Controls.Add(this.labelContactStreetAddress);
            this.Controls.Add(this.labelContactCity);
            this.Controls.Add(this.labelContactName);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelPostalCode);
            this.Controls.Add(this.labelStreetAddress);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxStreetAddress);
            this.Controls.Add(this.textBoxPostalCode);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonCreateNewContact);
            this.Controls.Add(this.listBoxContacts);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Name = "frmAdressbok";
            this.Text = "frmAdressbok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateNewContact;
        private System.Windows.Forms.ListBox listBoxContacts;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelContactEmail;
        private System.Windows.Forms.Label labelContactPostalCode;
        private System.Windows.Forms.Label labelContactPhoneNumber;
        private System.Windows.Forms.Label labelContactStreetAddress;
        private System.Windows.Forms.Label labelContactCity;
        private System.Windows.Forms.Label labelContactName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.Label labelStreetAddress;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxStreetAddress;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAbort;
        private System.Windows.Forms.Label labelContactId;
        private System.Windows.Forms.Button buttonDelete;
    }
}