namespace SeaWar_GameForm.SeaBattleController {
    partial class ShipBox {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.lbShoot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbShoot
            // 
            this.lbShoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbShoot.Font = new System.Drawing.Font("Bradley Hand ITC", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShoot.Location = new System.Drawing.Point(0, 0);
            this.lbShoot.Name = "lbShoot";
            this.lbShoot.Size = new System.Drawing.Size(45, 45);
            this.lbShoot.TabIndex = 0;
            this.lbShoot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbShoot.Visible = false;
            // 
            // CellCage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbShoot);
            this.Name = "CellCage";
            this.Size = new System.Drawing.Size(45, 45);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbShoot;
    }
}
