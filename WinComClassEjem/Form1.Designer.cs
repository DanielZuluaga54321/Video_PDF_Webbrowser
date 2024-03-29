namespace WinComClassEjem
{
    partial class btnPath
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnPath));
            this.PDF = new AxAcroPDFLib.AxAcroPDF();
            this.btnGenerarPDF = new System.Windows.Forms.Button();
            this.btnReproduirVideo = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnAdelante = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnIr = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.wmpVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.PDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // PDF
            // 
            this.PDF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PDF.Enabled = true;
            this.PDF.Location = new System.Drawing.Point(476, -36);
            this.PDF.Name = "PDF";
            this.PDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PDF.OcxState")));
            this.PDF.Size = new System.Drawing.Size(656, 275);
            this.PDF.TabIndex = 1;
            // 
            // btnGenerarPDF
            // 
            this.btnGenerarPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarPDF.Location = new System.Drawing.Point(610, 254);
            this.btnGenerarPDF.Name = "btnGenerarPDF";
            this.btnGenerarPDF.Size = new System.Drawing.Size(153, 46);
            this.btnGenerarPDF.TabIndex = 4;
            this.btnGenerarPDF.Text = "GENERAR  PDF";
            this.btnGenerarPDF.UseVisualStyleBackColor = true;
            this.btnGenerarPDF.Click += new System.EventHandler(this.btnGenerarPDF_Click);
            // 
            // btnReproduirVideo
            // 
            this.btnReproduirVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReproduirVideo.Location = new System.Drawing.Point(101, 254);
            this.btnReproduirVideo.Name = "btnReproduirVideo";
            this.btnReproduirVideo.Size = new System.Drawing.Size(246, 55);
            this.btnReproduirVideo.TabIndex = 5;
            this.btnReproduirVideo.Text = "Reproducir  video mostrar Ruta";
            this.btnReproduirVideo.UseVisualStyleBackColor = true;
            this.btnReproduirVideo.Click += new System.EventHandler(this.btnReproduirVideo_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(26, 315);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 6;
            this.btnAtras.Text = "<";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnAdelante
            // 
            this.btnAdelante.Location = new System.Drawing.Point(131, 315);
            this.btnAdelante.Name = "btnAdelante";
            this.btnAdelante.Size = new System.Drawing.Size(75, 23);
            this.btnAdelante.TabIndex = 7;
            this.btnAdelante.Text = ">";
            this.btnAdelante.UseVisualStyleBackColor = true;
            this.btnAdelante.Click += new System.EventHandler(this.btnAdelante_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(212, 315);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(374, 315);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(293, 315);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 10;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnIr
            // 
            this.btnIr.Location = new System.Drawing.Point(858, 315);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(75, 23);
            this.btnIr.TabIndex = 11;
            this.btnIr.Text = "ir";
            this.btnIr.UseVisualStyleBackColor = true;
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(455, 315);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(381, 20);
            this.txtURL.TabIndex = 12;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(511, 403);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(341, 217);
            this.webBrowser1.TabIndex = 13;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(26, 355);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(1094, 290);
            this.webBrowser2.TabIndex = 14;
            // 
            // wmpVideo
            // 
            this.wmpVideo.Enabled = true;
            this.wmpVideo.Location = new System.Drawing.Point(38, 12);
            this.wmpVideo.Name = "wmpVideo";
            this.wmpVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpVideo.OcxState")));
            this.wmpVideo.Size = new System.Drawing.Size(412, 227);
            this.wmpVideo.TabIndex = 0;
            // 
            // btnPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 866);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.btnIr);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdelante);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnReproduirVideo);
            this.Controls.Add(this.btnGenerarPDF);
            this.Controls.Add(this.PDF);
            this.Controls.Add(this.wmpVideo);
            this.Name = "btnPath";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpVideo;
        private AxAcroPDFLib.AxAcroPDF PDF;
        private System.Windows.Forms.Button btnGenerarPDF;
        private System.Windows.Forms.Button btnReproduirVideo;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnAdelante;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnIr;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

