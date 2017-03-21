namespace ex_5_21_03_DataView
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbID = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.lbDomaine = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.btCreation = new System.Windows.Forms.Button();
            this.btAjout = new System.Windows.Forms.Button();
            this.btAffichage = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbDomaine = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(32, 42);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(69, 17);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "Identifiant";
            this.lbID.Visible = false;
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(32, 75);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(37, 17);
            this.lbNom.TabIndex = 1;
            this.lbNom.Text = "Nom";
            this.lbNom.Visible = false;
            // 
            // lbDomaine
            // 
            this.lbDomaine.AutoSize = true;
            this.lbDomaine.Location = new System.Drawing.Point(32, 113);
            this.lbDomaine.Name = "lbDomaine";
            this.lbDomaine.Size = new System.Drawing.Size(64, 17);
            this.lbDomaine.TabIndex = 2;
            this.lbDomaine.Text = "Domaine";
            this.lbDomaine.Visible = false;
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(32, 144);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(33, 17);
            this.lbAge.TabIndex = 3;
            this.lbAge.Text = "Age";
            this.lbAge.Visible = false;
            // 
            // btCreation
            // 
            this.btCreation.Location = new System.Drawing.Point(35, 187);
            this.btCreation.Name = "btCreation";
            this.btCreation.Size = new System.Drawing.Size(75, 23);
            this.btCreation.TabIndex = 4;
            this.btCreation.Text = "Creation";
            this.btCreation.UseVisualStyleBackColor = true;
            this.btCreation.Click += new System.EventHandler(this.btCreation_Click);
            // 
            // btAjout
            // 
            this.btAjout.Location = new System.Drawing.Point(117, 186);
            this.btAjout.Name = "btAjout";
            this.btAjout.Size = new System.Drawing.Size(75, 23);
            this.btAjout.TabIndex = 5;
            this.btAjout.Text = "Ajout";
            this.btAjout.UseVisualStyleBackColor = true;
            this.btAjout.Click += new System.EventHandler(this.btAjout_Click);
            // 
            // btAffichage
            // 
            this.btAffichage.Location = new System.Drawing.Point(199, 186);
            this.btAffichage.Name = "btAffichage";
            this.btAffichage.Size = new System.Drawing.Size(75, 23);
            this.btAffichage.TabIndex = 6;
            this.btAffichage.Text = "Affichage";
            this.btAffichage.UseVisualStyleBackColor = true;
            this.btAffichage.Click += new System.EventHandler(this.btAffichage_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(101, 42);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 22);
            this.tbID.TabIndex = 7;
            this.tbID.Visible = false;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(101, 75);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(100, 22);
            this.tbNom.TabIndex = 8;
            this.tbNom.Visible = false;
            // 
            // tbDomaine
            // 
            this.tbDomaine.Location = new System.Drawing.Point(101, 113);
            this.tbDomaine.Name = "tbDomaine";
            this.tbDomaine.Size = new System.Drawing.Size(100, 22);
            this.tbDomaine.TabIndex = 9;
            this.tbDomaine.Visible = false;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(101, 141);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(100, 22);
            this.tbAge.TabIndex = 10;
            this.tbAge.Visible = false;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(27, 226);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(326, 122);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 383);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbDomaine);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.btAffichage);
            this.Controls.Add(this.btAjout);
            this.Controls.Add(this.btCreation);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lbDomaine);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.lbID);
            this.Name = "Form1";
            this.Text = "te";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbDomaine;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Button btCreation;
        private System.Windows.Forms.Button btAjout;
        private System.Windows.Forms.Button btAffichage;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbDomaine;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.ListView listView1;
    }
}

