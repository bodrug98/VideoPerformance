d i r e c t l y   m a p p e d   i n t o   t h e   a d d r e s s   s p a c e   o f   a p p l i c a t i o n s   ( a   h i g h - p e r f o r m a n c e   f e a t u r e   o f   W i n d o w s   N T ) .  
 2 7 0 = R e a d   B y t e s   N o n - P a g i n g / s e c  
 2 7 1 = R e a d   B y t e s   N o n - P a g i n g / s e c   a r e   t h o s e   b y t e s   r e a d   b y   t h e   R e d i r e c t o r   i n   r e s p o n s e   t o   n o r m a l   f i l e   r e q u e s t s   b y   a n   a p p l i c a t i o n   w h e n   t h e y   a r e   r e d i r e c t e d   t o   c o m e   f r o m   a n o t h e r   c o m p u t e r .     I n   a d d i t i o n   t o   f i l e   r e q u e s t s ,   t h i s   c o u n t e r   i n c l u d e s   o t h e r   m e t h o d s   o f   r e a d i n g   a c r o s s   t h e   n e t w o r k   s u c h   a s   N a m e d   P i p e s   a n d   T r a n s a c t i o n s .     T h i s   c o u n t e r   d o e s   n o t   c o u n t   n e t w o r k   p r o t o c o l   i n f o r m a t i o n ,   j u s t   a p p l i c a t i o n   d a t a .  
 2 7 2 = R e a d   B y t e s   C a c h e / s e c  
 2 7 3 = R e a d   B y t e s   C a c h e / s e c   i s   t h e   r a t e   a t   w h i c h   a p p l i c a t i o n s   a r e   a c c e s s i n g   t h e   f i l e   s y s t e m   c a c h e   b y   u s i n g   t h e   R e d i r e c t o r .     S o m e   o f   t h e s e   d a t a   r e q u e s t s   a r e   s a t i s f i e d   b y   r e t r i e v i n g   t h e   d a t a   f r o m   t h e   c a c h e .     R e q u e s t s   t h a t   m i s s   t h e   C a c h e   c a u s e   a   p a g e   f a u l t   ( s e e   R e a d   B y t e s   P a g i n g / s e c ) .  
 2 7 4 = R e a d   B y t e s   N e t w o r k / s e c  
 2 7 5 = R e a d   B y t e s   N e t w o r k / s e c   i s   t h e   r a t e   a t   w h i c h   a p p l i c a t i o n s   a r e   r e a d i n g   d a t a   a c r o s s   t h e   n e t w o r k .   T h i s   o c c u r s   w h e n   d a t a   s o u g h t   i n   t h e   f i l e   s y s t e m   c a c h e   i s   n o t   f o u n d   t h e r e   a n d   m u s t   b e   r e t r i e v e d   f r o m   t h e   n e t w o r k .     D i v i d i n g   t h i s   v a l u e   b y   B y t e s   R e c e i v e d / s e c   i n d i c a t e s   t h e   p r o p o r t i o n   o f   a p p l i c a t i o n   d a t a   t r a v e l i n g   a c r o s s   t h e   n e t w o r k .   ( s e e   B y t e s   R e c e i v e d / s e c ) .  
 2 7 6 = B y t e s   T r a n s m i t t e d / s e c  
 2 7 7 = B y t e s   T r a n s m i t t e d / s e c   i s   t h e   r a t e   a t   w h i c h   b y t e s   a r e   l e a v i n g   t h e   R e d i r e c t o r   t o   t h e   n e t w o r k .     I t   i n c l u d e s   a l l   a p p l i c a t i o n   d a t a   a s   w e l l   a s   n e t w o r k   p r o t o c o l   i n f o r m a t i o n   ( s u c h   a s   p a c k e t   h e a d e r s   a n d   t h e   l i k e ) .  
 2 7 8 = P a c k e t s   T r a n s m i t t e d / s e c  
 2 7 9 = P a c k e t s   T r a n s m i t t e d / s e c   i s   t h e   r a t e   a t   w h i c h   t h e   R e d i r e c t o r   i s   s e n d i n g   p a c k e t s   ( a l s o   c a l l e d   S M B s   o r   S e r v e r   M e s s a g e   B l o c k s ) .     N e t w o r k   t r a n s m i s s i o n s   a r e   d i v i d e d   i n t o   p a c k e t s .     T h e   a v e r a g e   n u m b e r   o f   b y t e s   t r a n s m i t t e d   i n   a   p a c k e t   c a n   b e   o b t a i n e d   b y   d i v i d i n g   B y t e s   T r a n s m i t t e d / s e c   b y   t h i s   c o u n t e r .  
 2 8 0 = W r i t e   B y t e s   P a g i n g / s e c  
 2 8 1 = W r i t e   B y t e s   P a g i n g / s e c   i s   t h e   r a t e   a t   w h i c h   t h e   R e d i r e c t o r   i s   a t t e m p t i n g   t o   w r i t e   b y t e s   c h a n g e d   i n   t h e   p a g e s   b e i n g   u s e d   b y   a p p l i c a t i o n s .     T h e   p r o g r a m   d a t a   c h a n g e d   b y   m o d u l e s   ( s u c h   a s   p r o g r a m s   a n d   l i b r a r i e s )   t h a t   w e r e   l o a d e d   o v e r   t h e   n e t w o r k   a r e   ' p a g e d   o u t '   w h e n   n o   l o n g e r   n e e d e d .     O t h e r   o u t p u t   p a g e s   c o m e   f r o m   t h e   f i l e   s y s t e m   c a c h e   ( s e e   W r i t e   B y t e s   C a c h e / s e c ) .  
 2 8 2 = W r i t e   B y t e s   N o n - P a g i n g / s e c  
 2 8 3 = W r i t e   B y t e s   N o n - P a g i n g / s e c   i s   t h e   r a t e   a t   w h i c h   b y t e s   a r e   w r i t t e n   b y   t h e   R e d i r e c t o r   i n   r e s p o n s e   t o   n o r m a l   f i l e   o u t p u t s   b y   a n   a p p l i c a t i o n   w h e n   t h e y   a r e   r e d i r e c t e d   t o   a n o t h e r   c o m p u t e r .     I n   a d d i t i o n   t o   f i l e   r e q u e s t s ,   t h i s   c o u n t   i n c l u d e s   o t h e r   m e t h o d s   o f   w r i t i n g   a c r o s s   t h e   n e t w o r k ,   s u c h   a s   N a m e d   P i p e s   a n d   T r a n s a c t i o n s .     T h i s   c o u n t e r   d o e s   n o t   c o u n t   n e t w o r k   p r o t o c o l   i n f o r m a t i o n ,   j u s t   a p p l i c a t i o n   d a t a .  
 2 8 4 = W r i t e   B y t e s   C a c h e / s e c  
 2 8 5 = W r i t e   B y t e s   C a c h e / s e c   i s   t h e   r a t e   a t   w h i c h   a p p l i c a t i o n s   o n   y o u r   c o m p u t e r   a r e   w r i t i n g   t o   t h e   f i l e   s y s t e m   c a c h e   b y   u s i n g   t h e   R e d i r e c t o r .     T h e   d a t a   m i g h t   n o t   l e a v e   y o u r   c o m p u t e r   i m m e d i a t e l y ;   i t   c a n   b e   r e t a i n e d   i n   t h e   c a c h e   f o r   f u r t h e r   m o d i f i c a t i o n   b e f o r e   b e i n g   w r i t t e n   t o   t h e   n e t w o r k .     T h i s   s a v e s   n e t w o r k   t r a f f i c .     E a c h   w r i t e   o f   a   b y t e   i n t o   t h e   c a c h e   i s   c o u n t e d   h e r e .  
 2 8 6 = W r i t e   B y t e s   N e t w o r k / s e c  
 2 8 7 = W r i t e   B y t e s   N e t w o r k / s e c   i s   t h e   r a t e   a t   w h i c h   a p p l i c a t i o n s   a r e   w r i t i n g   d a t a   a c r o s s   t h e   n e t w o r k .   T h i s   o c c u r s   w h e n   t h e   f i l e   s y s t e m   c a c h e   i s   b y p a s s e d ,   s u c h   a s   f o r   N a m e d   P i p e s   o r   T r a n s a c t i o n s ,   o r   w h e n   t h e   c a c h e   w r i t e s   t h e   b y t e s   t o   d i s k   t o   m a k e   r o o m   f o r   o t h e r   d a t a .     D i v i d i n g   t h i s   c o u n t e r   b y   B y t e s   T r a n s m i t t e d / s e c   w i l l   i n d i c a t e   t h e   p r o p o r t i o n   o f   a p p l i c a t i o n   d a t a   b e i n g   t o   t h e   n e t w o r k   ( s e e   T r a n s m i t t e d   B y t e s / s e c ) .  
 2 8 8 = R e a d   O p e r a t i o n s / s e c  
 2 8 9 = F i l e   R e a d   O p e r a t i o n s / s e c   i s   t h e   r a t e   a t   w h i c h   a p p l i c a t i o n s   a r e   a s k i n g   t h e   R e d i r e c t o r   f o r   d a t a .   E a c h   c a l l   t o   a   f i l e   s y s t e m   o r   s i m i l a r   A p p l i c a t i o n   P r o g r a m   I n t e r f a c e   ( A P I )   c a l l   c o u n t s   a s   o n e   o p e r a t i o n .  
 2 9 0 = R e a d   O p e r a t i o n s   R a n d o m / s e c  
 2 9 1 = R e a d   O p e r a t i o n s   R a n d o m / s e c   c o u n t s   t h e   r a t e   a t   w h i c h ,   o n   a   f i l e - b y - f i l e   b a s i s ,   r e a d s   a r e   m a d e   t h a t   a r e   n o t   s e q u e n t i a l .     I f   a   r e a d   i s   m a d e   u s i n g   a   p a r t i c u l a r   f i l e   h a n d l e ,   a n d   t h e n   i s   f o l l o w e d   b y   a n o t h e r   r e a d   t h a t   i s   n o t   i m m e d i a t e l y   t h e   c o n t i g u o u s   n e x t   b y t e ,   t h i s   c o u n t e r   i s   i n c r e m e n t e d   b y   o n e .  
 2 9 2 = R e a d   P a c k e t s / s e c  
 2 9 3 = R e a d   P a c k e t s / s e c   i s   t h e   r a t e   a t   w h i c h   r e a d   p a c k e t s   a r e   b e i n g    this.textBox5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox5.Location = new System.Drawing.Point(163, 256);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(227, 26);
            this.textBox5.TabIndex = 3;
            this.textBox5.Text = "Password";
            this.textBox5.Enter += new System.EventHandler(this.textBox5_Enter);
            this.textBox5.Leave += new System.EventHandler(this.textBox5_Leave);
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox6.HideSelection = false;
            this.textBox6.Location = new System.Drawing.Point(163, 206);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(227, 26);
            this.textBox6.TabIndex = 2;
            this.textBox6.Text = "Login";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.textBox6.Enter += new System.EventHandler(this.textBox6_Enter);
            this.textBox6.Leave += new System.EventHandler(this.textBox6_Leave);
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox7.Location = new System.Drawing.Point(163, 306);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(227, 26);
            this.textBox7.TabIndex = 4;
            this.textBox7.Text = "Confirm the password";
            this.textBox7.Enter += new System.EventHandler(this.textBox7_Enter);
            this.textBox7.Leave += new System.EventHandler(this.textBox7_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(234, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 40);
            this.button1.TabIndex = 5;
            this.button1.Tag = "";
            this.button1.Text = "Sign up";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(61, 378);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 40);
            this.button3.TabIndex = 6;
            this.button3.Text = "<    Back";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FirstApp.Properties.Resources.signUp;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 116);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // nickLabel
            // 
            this.nickLabel.AutoSize = true;
            this.nickLabel.ForeColor = System.Drawing.Color.Red;
            this.nickLabel.Location = new System.Drawing.Point(184, 136);
            this.nickLabel.Name = "nickLabel";
            this.nickLabel.Size = new System.Drawing.Size(0, 13);
            this.nickLabel.TabIndex = 10;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.ForeColor = System.Drawing.Color.Red;
            this.emailLabel.Location = new System.Drawing.Point(184, 186);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(0, 13);
            this.emailLabel.TabIndex = 11;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.ForeColor = System.Drawing.Color.Red;
            this.loginLabel.Location = new System.Drawing.Point(184, 235);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(0, 13);
            this.loginLabel.TabIndex = 12;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.ForeColor = System.Drawing.Color.Red;
            this.passLabel.Location = new System.Drawing.Point(184, 285);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(0, 13);
            this.passLabel.TabIndex = 13;
            // 
            // pass2Label
            // 
            this.pass2Label.AutoSize = true;
            this.pass2Label.ForeColor = System.Drawing.Color.Red;
            this.pass2Label.Location = new System.Drawing.Point(184, 335);
            this.pass2Label.Name = "pass2Label";
            this.pass2Label.Size = new System.Drawing.Size(0, 13);
            this.pass2Label.TabIndex = 14;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(425, 435);
            this.Controls.Add(this.pass2Label);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nickLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label nickLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label pass2Label;
    }
}