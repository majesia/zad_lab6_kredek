
namespace zad_lab6
{
    partial class Start
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.start_button = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeButton = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.start_button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.start_button.ForeColor = System.Drawing.SystemColors.InfoText;
            this.start_button.Location = new System.Drawing.Point(65, 80);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(369, 137);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // toolTip1
            // 
            //this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(119, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 58);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeButton
            // 
            this.timeButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.timeButton.Location = new System.Drawing.Point(155, 23);
            this.timeButton.Name = "timeButton";
            this.timeButton.Size = new System.Drawing.Size(200, 36);
            this.timeButton.TabIndex = 2;
            this.timeButton.Text = "Włącz zegar";
            this.timeButton.UseVisualStyleBackColor = false;
            this.timeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolTip2
            // 
            this.toolTip2.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip2_Popup);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(500, 430);
            this.Controls.Add(this.timeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start_button);
            this.Name = "Start";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button timeButton;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}

