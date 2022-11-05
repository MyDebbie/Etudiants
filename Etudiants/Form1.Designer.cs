
namespace Etudiants
{
    partial class Form1
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lbNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lbNationalite = new System.Windows.Forms.Label();
            this.lbPrenom1 = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbPrenom2 = new System.Windows.Forms.Label();
            this.lbVille = new System.Windows.Forms.Label();
            this.lbAdresse = new System.Windows.Forms.Label();
            this.lbTelephone = new System.Windows.Forms.Label();
            this.txtPrenom2 = new System.Windows.Forms.TextBox();
            this.txtNationalite = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtPrenom1 = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lvPersonne = new System.Windows.Forms.ListView();
            this.lbPays = new System.Windows.Forms.Label();
            this.txtPays = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(89, 558);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(153, 51);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.Location = new System.Drawing.Point(31, 76);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(59, 25);
            this.lbNom.TabIndex = 14;
            this.lbNom.Text = "Nom:";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(137, 80);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(202, 22);
            this.txtNom.TabIndex = 0;
            // 
            // lbNationalite
            // 
            this.lbNationalite.AutoSize = true;
            this.lbNationalite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNationalite.Location = new System.Drawing.Point(23, 276);
            this.lbNationalite.Name = "lbNationalite";
            this.lbNationalite.Size = new System.Drawing.Size(109, 25);
            this.lbNationalite.TabIndex = 22;
            this.lbNationalite.Text = "Nationalité:";
            // 
            // lbPrenom1
            // 
            this.lbPrenom1.AutoSize = true;
            this.lbPrenom1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrenom1.Location = new System.Drawing.Point(417, 84);
            this.lbPrenom1.Name = "lbPrenom1";
            this.lbPrenom1.Size = new System.Drawing.Size(97, 25);
            this.lbPrenom1.TabIndex = 38;
            this.lbPrenom1.Text = "Prénom1:";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAge.Location = new System.Drawing.Point(425, 181);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(54, 25);
            this.lbAge.TabIndex = 9;
            this.lbAge.Text = "Age:";
            // 
            // lbPrenom2
            // 
            this.lbPrenom2.AutoSize = true;
            this.lbPrenom2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrenom2.Location = new System.Drawing.Point(23, 181);
            this.lbPrenom2.Name = "lbPrenom2";
            this.lbPrenom2.Size = new System.Drawing.Size(97, 25);
            this.lbPrenom2.TabIndex = 11;
            this.lbPrenom2.Text = "Prénom2:";
            // 
            // lbVille
            // 
            this.lbVille.AutoSize = true;
            this.lbVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVille.Location = new System.Drawing.Point(23, 390);
            this.lbVille.Name = "lbVille";
            this.lbVille.Size = new System.Drawing.Size(55, 25);
            this.lbVille.TabIndex = 12;
            this.lbVille.Text = "Ville:";
            // 
            // lbAdresse
            // 
            this.lbAdresse.AutoSize = true;
            this.lbAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdresse.Location = new System.Drawing.Point(402, 275);
            this.lbAdresse.Name = "lbAdresse";
            this.lbAdresse.Size = new System.Drawing.Size(91, 25);
            this.lbAdresse.TabIndex = 13;
            this.lbAdresse.Text = "Adresse:";
            // 
            // lbTelephone
            // 
            this.lbTelephone.AutoSize = true;
            this.lbTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelephone.Location = new System.Drawing.Point(402, 389);
            this.lbTelephone.Name = "lbTelephone";
            this.lbTelephone.Size = new System.Drawing.Size(112, 25);
            this.lbTelephone.TabIndex = 14;
            this.lbTelephone.Text = "Téléphone:";
            // 
            // txtPrenom2
            // 
            this.txtPrenom2.Location = new System.Drawing.Point(137, 184);
            this.txtPrenom2.Name = "txtPrenom2";
            this.txtPrenom2.Size = new System.Drawing.Size(202, 22);
            this.txtPrenom2.TabIndex = 2;
            // 
            // txtNationalite
            // 
            this.txtNationalite.Location = new System.Drawing.Point(138, 279);
            this.txtNationalite.Name = "txtNationalite";
            this.txtNationalite.Size = new System.Drawing.Size(202, 22);
            this.txtNationalite.TabIndex = 4;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(138, 393);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(202, 22);
            this.txtVille.TabIndex = 6;
            // 
            // txtPrenom1
            // 
            this.txtPrenom1.Location = new System.Drawing.Point(532, 88);
            this.txtPrenom1.Name = "txtPrenom1";
            this.txtPrenom1.Size = new System.Drawing.Size(202, 22);
            this.txtPrenom1.TabIndex = 1;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(532, 185);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(202, 22);
            this.txtAge.TabIndex = 3;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(532, 275);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(202, 22);
            this.txtAdresse.TabIndex = 5;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(532, 389);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(202, 22);
            this.txtTelephone.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(485, 558);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(153, 51);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lvPersonne
            // 
            this.lvPersonne.HideSelection = false;
            this.lvPersonne.Location = new System.Drawing.Point(758, 80);
            this.lvPersonne.Name = "listView1";
            this.lvPersonne.Size = new System.Drawing.Size(653, 544);
            this.lvPersonne.TabIndex = 23;
            this.lvPersonne.UseCompatibleStateImageBehavior = false;
            // 
            // lbPays
            // 
            this.lbPays.AutoSize = true;
            this.lbPays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPays.Location = new System.Drawing.Point(23, 477);
            this.lbPays.Name = "lbPays";
            this.lbPays.Size = new System.Drawing.Size(55, 25);
            this.lbPays.TabIndex = 39;
            this.lbPays.Text = "Pays:";
            // 
            // txtPays
            // 
            this.txtPays.Location = new System.Drawing.Point(137, 477);
            this.txtPays.Name = "txtPays";
            this.txtPays.Size = new System.Drawing.Size(202, 22);
            this.txtPays.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 711);
            this.Controls.Add(this.txtPays);
            this.Controls.Add(this.lbPays);
            this.Controls.Add(this.lvPersonne);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtPrenom1);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.txtNationalite);
            this.Controls.Add(this.txtPrenom2);
            this.Controls.Add(this.lbTelephone);
            this.Controls.Add(this.lbAdresse);
            this.Controls.Add(this.lbVille);
            this.Controls.Add(this.lbPrenom2);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lbPrenom1);
            this.Controls.Add(this.lbNationalite);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lbNationalite;
        private System.Windows.Forms.Label lbPrenom1;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbPrenom2;
        private System.Windows.Forms.Label lbVille;
        private System.Windows.Forms.Label lbAdresse;
        private System.Windows.Forms.Label lbTelephone;
        private System.Windows.Forms.TextBox txtPrenom2;
        private System.Windows.Forms.TextBox txtNationalite;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtPrenom1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListView lvPersonne;
        private System.Windows.Forms.Label lbPays;
        private System.Windows.Forms.TextBox txtPays;
    }
}

