using System.Drawing;
namespace Demo_LoadDLL
{
    partial class testForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(testForm));
            this.Load = new System.Windows.Forms.Button();
            this.Load_Cpp = new System.Windows.Forms.Button();
            this.Load_E = new System.Windows.Forms.Button();
            this.Load_Cs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(12, 12);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(163, 60);
            this.Load.TabIndex = 0;
            this.Load.Text = "Load Skin";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Load_Cpp
            // 
            this.Load_Cpp.Location = new System.Drawing.Point(181, 12);
            this.Load_Cpp.Name = "Load_Cpp";
            this.Load_Cpp.Size = new System.Drawing.Size(163, 60);
            this.Load_Cpp.TabIndex = 1;
            this.Load_Cpp.Text = "Load Cpp";
            this.Load_Cpp.UseVisualStyleBackColor = true;
            this.Load_Cpp.Click += new System.EventHandler(this.Load_Cpp_Click);
            // 
            // Load_E
            // 
            this.Load_E.Location = new System.Drawing.Point(350, 12);
            this.Load_E.Name = "Load_E";
            this.Load_E.Size = new System.Drawing.Size(163, 60);
            this.Load_E.TabIndex = 2;
            this.Load_E.Text = "Load E";
            this.Load_E.UseVisualStyleBackColor = true;
            this.Load_E.Click += new System.EventHandler(this.Load_E_Click);
            // 
            // Load_Cs
            // 
            this.Load_Cs.Location = new System.Drawing.Point(519, 12);
            this.Load_Cs.Name = "Load_Cs";
            this.Load_Cs.Size = new System.Drawing.Size(163, 60);
            this.Load_Cs.TabIndex = 3;
            this.Load_Cs.Text = "Load C#";
            this.Load_Cs.UseVisualStyleBackColor = true;
            this.Load_Cs.Click += new System.EventHandler(this.Load_Cs_Click);
            // 
            // testForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 91);
            this.Controls.Add(this.Load_Cs);
            this.Controls.Add(this.Load_E);
            this.Controls.Add(this.Load_Cpp);
            this.Controls.Add(this.Load);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "testForm";
            this.Text = "Test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button Load_Cpp;
        private System.Windows.Forms.Button Load_E;
        private System.Windows.Forms.Button Load_Cs;
    }
}

