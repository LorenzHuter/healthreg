namespace HealthReg
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.patienten = new HealthReg.Patienten();
            this.patientenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientenTableAdapter = new HealthReg.PatientenTableAdapters.PatientenTableAdapter();
            this.tableAdapterManager = new HealthReg.PatientenTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.patienten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // patienten
            // 
            this.patienten.DataSetName = "Patienten";
            this.patienten.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientenBindingSource
            // 
            this.patientenBindingSource.DataMember = "Patienten";
            this.patientenBindingSource.DataSource = this.patienten;
            // 
            // patientenTableAdapter
            // 
            this.patientenTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = HealthReg.PatientenTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 345);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patienten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientenBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Patienten patienten;
        private System.Windows.Forms.BindingSource patientenBindingSource;
        private PatientenTableAdapters.PatientenTableAdapter patientenTableAdapter;
        private PatientenTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

