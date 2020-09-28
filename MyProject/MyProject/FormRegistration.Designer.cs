namespace MyProject
{
    partial class FormRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistration));
            this.labelBuy = new System.Windows.Forms.Label();
            this.labelNumberTicket = new System.Windows.Forms.Label();
            this.labelStartMovie = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelRow = new System.Windows.Forms.Label();
            this.labelFilm = new System.Windows.Forms.Label();
            this.labelHoll = new System.Windows.Forms.Label();
            this.labelNameTicket = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBuy
            // 
            this.labelBuy.AutoSize = true;
            this.labelBuy.BackColor = System.Drawing.Color.Transparent;
            this.labelBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBuy.Location = new System.Drawing.Point(0, 270);
            this.labelBuy.Name = "labelBuy";
            this.labelBuy.Size = new System.Drawing.Size(104, 25);
            this.labelBuy.TabIndex = 18;
            this.labelBuy.Text = "Оплачено";
            // 
            // labelNumberTicket
            // 
            this.labelNumberTicket.AutoSize = true;
            this.labelNumberTicket.BackColor = System.Drawing.Color.Transparent;
            this.labelNumberTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberTicket.Location = new System.Drawing.Point(0, 300);
            this.labelNumberTicket.Name = "labelNumberTicket";
            this.labelNumberTicket.Size = new System.Drawing.Size(103, 25);
            this.labelNumberTicket.TabIndex = 17;
            this.labelNumberTicket.Text = "№ билета";
            // 
            // labelStartMovie
            // 
            this.labelStartMovie.AutoSize = true;
            this.labelStartMovie.BackColor = System.Drawing.Color.Transparent;
            this.labelStartMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStartMovie.Location = new System.Drawing.Point(0, 210);
            this.labelStartMovie.Name = "labelStartMovie";
            this.labelStartMovie.Size = new System.Drawing.Size(203, 31);
            this.labelStartMovie.TabIndex = 16;
            this.labelStartMovie.Text = "Начало сеанса";
            this.labelStartMovie.Click += new System.EventHandler(this.labelStartMovie_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(0, 172);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(77, 31);
            this.labelDate.TabIndex = 15;
            this.labelDate.Text = "Дата";
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.BackColor = System.Drawing.Color.Transparent;
            this.labelPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlace.Location = new System.Drawing.Point(90, 103);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(92, 31);
            this.labelPlace.TabIndex = 14;
            this.labelPlace.Text = "Место";
            // 
            // labelRow
            // 
            this.labelRow.AutoSize = true;
            this.labelRow.BackColor = System.Drawing.Color.Transparent;
            this.labelRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRow.Location = new System.Drawing.Point(0, 103);
            this.labelRow.Name = "labelRow";
            this.labelRow.Size = new System.Drawing.Size(63, 31);
            this.labelRow.TabIndex = 13;
            this.labelRow.Text = "Ряд";
            // 
            // labelFilm
            // 
            this.labelFilm.AutoSize = true;
            this.labelFilm.BackColor = System.Drawing.Color.Transparent;
            this.labelFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFilm.Location = new System.Drawing.Point(81, 50);
            this.labelFilm.Name = "labelFilm";
            this.labelFilm.Size = new System.Drawing.Size(71, 24);
            this.labelFilm.TabIndex = 12;
            this.labelFilm.Text = "Фильм";
            // 
            // labelHoll
            // 
            this.labelHoll.AutoSize = true;
            this.labelHoll.BackColor = System.Drawing.Color.Transparent;
            this.labelHoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHoll.Location = new System.Drawing.Point(0, 50);
            this.labelHoll.Name = "labelHoll";
            this.labelHoll.Size = new System.Drawing.Size(43, 24);
            this.labelHoll.TabIndex = 11;
            this.labelHoll.Text = "Зал";
            // 
            // labelNameTicket
            // 
            this.labelNameTicket.AutoSize = true;
            this.labelNameTicket.BackColor = System.Drawing.Color.Yellow;
            this.labelNameTicket.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameTicket.Location = new System.Drawing.Point(0, 0);
            this.labelNameTicket.Name = "labelNameTicket";
            this.labelNameTicket.Size = new System.Drawing.Size(136, 34);
            this.labelNameTicket.TabIndex = 10;
            this.labelNameTicket.Text = "КИНОМАКС";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSave.BackgroundImage = global::MyProject.Properties.Resources.iconfinder_save_2561379_png;
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Location = new System.Drawing.Point(321, 0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(35, 35);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.BackgroundImage = global::MyProject.Properties.Resources.iconfinder_arrow_back_outline_216436_png;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(288, 293);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(35, 35);
            this.buttonBack.TabIndex = 21;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.BackgroundImage = global::MyProject.Properties.Resources.iconfinder_icons_exit2_1564506_png;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(321, 293);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(35, 35);
            this.buttonExit.TabIndex = 22;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyProject.Properties.Resources.Фон;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(355, 328);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelBuy);
            this.Controls.Add(this.labelNumberTicket);
            this.Controls.Add(this.labelStartMovie);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelPlace);
            this.Controls.Add(this.labelRow);
            this.Controls.Add(this.labelFilm);
            this.Controls.Add(this.labelHoll);
            this.Controls.Add(this.labelNameTicket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FormRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormRegistration_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormRegistration_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormRegistration_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBuy;
        private System.Windows.Forms.Label labelNumberTicket;
        private System.Windows.Forms.Label labelStartMovie;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Label labelRow;
        private System.Windows.Forms.Label labelFilm;
        private System.Windows.Forms.Label labelHoll;
        private System.Windows.Forms.Label labelNameTicket;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonExit;
    }
}