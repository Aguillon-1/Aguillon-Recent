namespace Classroom_Management_System
{
    partial class HomeForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            SideMenuBar = new Panel();
            ClassesDropDownPanel = new Panel();
            ClassesButton = new Button();
            rolePanel = new Panel();
            username = new Label();
            email = new Label();
            roleLabel = new Label();
            ProfilePic = new PictureBox();
            LogoHoderPanel = new Panel();
            MenuButton = new Button();
            logoHolderPictureBox = new PictureBox();
            titleLabel = new Label();
            containerPanel = new Panel();
            approvePanel = new Panel();
            approvalDropDownPanel = new Panel();
            changeProfileButton = new Button();
            changeEmailOption = new Button();
            selectButton = new Button();
            requestButton = new ClassroomManagementSystem.Custom.CustomButton();
            approvalDirectionLabel = new Label();
            approvalLabel = new Label();
            joinClassPanel = new Panel();
            label1 = new Label();
            submitButton = new ClassroomManagementSystem.Custom.CustomButton();
            codeLabel = new Label();
            textBox1 = new TextBox();
            joinClassLabel = new Label();
            welcomePanel = new Panel();
            accesslabel = new Label();
            introlabel = new Label();
            handwavepicturebox = new PictureBox();
            WelcomeLabel = new Label();
            classesPanel = new Panel();
            button1 = new Button();
            panel1 = new Panel();
            classesLabel = new Label();
            approvalDropDownTimer = new System.Windows.Forms.Timer(components);
            logOutButton = new ClassroomManagementSystem.Custom.CustomButton();
            userButton = new ClassroomManagementSystem.Custom.CustomButton();
            homeButton = new ClassroomManagementSystem.Custom.CustomButton();
            notifButton = new ClassroomManagementSystem.Custom.CustomButton();
            SideMenuBar.SuspendLayout();
            rolePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilePic).BeginInit();
            LogoHoderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoHolderPictureBox).BeginInit();
            containerPanel.SuspendLayout();
            approvePanel.SuspendLayout();
            approvalDropDownPanel.SuspendLayout();
            joinClassPanel.SuspendLayout();
            welcomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)handwavepicturebox).BeginInit();
            classesPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SideMenuBar
            // 
            SideMenuBar.BackColor = Color.FromArgb(30, 38, 51);
            SideMenuBar.Controls.Add(ClassesDropDownPanel);
            SideMenuBar.Controls.Add(ClassesButton);
            SideMenuBar.Controls.Add(rolePanel);
            SideMenuBar.Controls.Add(LogoHoderPanel);
            SideMenuBar.Dock = DockStyle.Left;
            SideMenuBar.Location = new Point(0, 0);
            SideMenuBar.Margin = new Padding(0);
            SideMenuBar.Name = "SideMenuBar";
            SideMenuBar.Size = new Size(297, 815);
            SideMenuBar.TabIndex = 0;
            // 
            // ClassesDropDownPanel
            // 
            ClassesDropDownPanel.BackColor = Color.FromArgb(59, 73, 97);
            ClassesDropDownPanel.Dock = DockStyle.Top;
            ClassesDropDownPanel.Location = new Point(0, 320);
            ClassesDropDownPanel.Margin = new Padding(3, 4, 3, 4);
            ClassesDropDownPanel.Name = "ClassesDropDownPanel";
            ClassesDropDownPanel.Size = new Size(297, 204);
            ClassesDropDownPanel.TabIndex = 3;
            // 
            // ClassesButton
            // 
            ClassesButton.Dock = DockStyle.Top;
            ClassesButton.FlatAppearance.BorderSize = 0;
            ClassesButton.FlatStyle = FlatStyle.Flat;
            ClassesButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClassesButton.ForeColor = SystemColors.ButtonHighlight;
            ClassesButton.ImageAlign = ContentAlignment.MiddleRight;
            ClassesButton.Location = new Point(0, 263);
            ClassesButton.Margin = new Padding(0);
            ClassesButton.Name = "ClassesButton";
            ClassesButton.Padding = new Padding(6, 0, 23, 0);
            ClassesButton.Size = new Size(297, 57);
            ClassesButton.TabIndex = 2;
            ClassesButton.Text = "CLASSES";
            ClassesButton.TextAlign = ContentAlignment.MiddleLeft;
            ClassesButton.UseVisualStyleBackColor = true;
            // 
            // rolePanel
            // 
            rolePanel.BackColor = Color.FromArgb(59, 73, 97);
            rolePanel.Controls.Add(username);
            rolePanel.Controls.Add(email);
            rolePanel.Controls.Add(roleLabel);
            rolePanel.Controls.Add(ProfilePic);
            rolePanel.Dock = DockStyle.Top;
            rolePanel.Location = new Point(0, 119);
            rolePanel.Margin = new Padding(3, 4, 3, 4);
            rolePanel.Name = "rolePanel";
            rolePanel.Size = new Size(297, 144);
            rolePanel.TabIndex = 1;
            // 
            // username
            // 
            username.AutoSize = true;
            username.ForeColor = SystemColors.ButtonHighlight;
            username.Location = new Point(115, 80);
            username.Name = "username";
            username.Size = new Size(73, 20);
            username.TabIndex = 3;
            username.Text = "username";
            // 
            // email
            // 
            email.AutoSize = true;
            email.ForeColor = SystemColors.ButtonHighlight;
            email.Location = new Point(115, 100);
            email.Name = "email";
            email.Size = new Size(46, 20);
            email.TabIndex = 2;
            email.Text = "email";
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roleLabel.ForeColor = SystemColors.ButtonHighlight;
            roleLabel.Location = new Point(128, 17);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(116, 32);
            roleLabel.TabIndex = 1;
            roleLabel.Text = "STUDENT";
            // 
            // ProfilePic
            // 
            ProfilePic.BackgroundImage = (Image)resources.GetObject("ProfilePic.BackgroundImage");
            ProfilePic.BackgroundImageLayout = ImageLayout.Center;
            ProfilePic.Location = new Point(14, 40);
            ProfilePic.Margin = new Padding(3, 4, 3, 4);
            ProfilePic.Name = "ProfilePic";
            ProfilePic.Size = new Size(83, 80);
            ProfilePic.TabIndex = 0;
            ProfilePic.TabStop = false;
            // 
            // LogoHoderPanel
            // 
            LogoHoderPanel.Controls.Add(MenuButton);
            LogoHoderPanel.Controls.Add(logoHolderPictureBox);
            LogoHoderPanel.Dock = DockStyle.Top;
            LogoHoderPanel.Location = new Point(0, 0);
            LogoHoderPanel.Margin = new Padding(3, 4, 3, 4);
            LogoHoderPanel.Name = "LogoHoderPanel";
            LogoHoderPanel.Size = new Size(297, 119);
            LogoHoderPanel.TabIndex = 0;
            // 
            // MenuButton
            // 
            MenuButton.FlatAppearance.BorderSize = 0;
            MenuButton.FlatStyle = FlatStyle.Flat;
            MenuButton.Image = (Image)resources.GetObject("MenuButton.Image");
            MenuButton.Location = new Point(31, 33);
            MenuButton.Margin = new Padding(3, 4, 3, 4);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(56, 51);
            MenuButton.TabIndex = 1;
            MenuButton.UseVisualStyleBackColor = true;
            // 
            // logoHolderPictureBox
            // 
            logoHolderPictureBox.Image = (Image)resources.GetObject("logoHolderPictureBox.Image");
            logoHolderPictureBox.Location = new Point(176, 25);
            logoHolderPictureBox.Margin = new Padding(3, 4, 3, 4);
            logoHolderPictureBox.Name = "logoHolderPictureBox";
            logoHolderPictureBox.Size = new Size(59, 55);
            logoHolderPictureBox.TabIndex = 0;
            logoHolderPictureBox.TabStop = false;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Microsoft Sans Serif", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(318, 25);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(749, 46);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "CLASSROOM MANAGEMENT SYSTEM";
            // 
            // containerPanel
            // 
            containerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            containerPanel.BackgroundImage = Properties.Resources.container;
            containerPanel.Controls.Add(approvePanel);
            containerPanel.Controls.Add(joinClassPanel);
            containerPanel.Controls.Add(welcomePanel);
            containerPanel.Controls.Add(classesPanel);
            containerPanel.Location = new Point(318, 159);
            containerPanel.Margin = new Padding(3, 4, 3, 4);
            containerPanel.Name = "containerPanel";
            containerPanel.Size = new Size(1301, 679);
            containerPanel.TabIndex = 2;
            // 
            // approvePanel
            // 
            approvePanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            approvePanel.BackColor = Color.Transparent;
            approvePanel.BackgroundImage = (Image)resources.GetObject("approvePanel.BackgroundImage");
            approvePanel.BackgroundImageLayout = ImageLayout.Zoom;
            approvePanel.Controls.Add(approvalDropDownPanel);
            approvePanel.Controls.Add(requestButton);
            approvePanel.Controls.Add(approvalDirectionLabel);
            approvePanel.Controls.Add(approvalLabel);
            approvePanel.Location = new Point(929, 366);
            approvePanel.Margin = new Padding(3, 4, 3, 4);
            approvePanel.Name = "approvePanel";
            approvePanel.Size = new Size(326, 265);
            approvePanel.TabIndex = 3;
            approvePanel.Paint += approvePanel_Paint;
            // 
            // approvalDropDownPanel
            // 
            approvalDropDownPanel.BorderStyle = BorderStyle.FixedSingle;
            approvalDropDownPanel.Controls.Add(changeProfileButton);
            approvalDropDownPanel.Controls.Add(changeEmailOption);
            approvalDropDownPanel.Controls.Add(selectButton);
            approvalDropDownPanel.Location = new Point(93, 133);
            approvalDropDownPanel.Margin = new Padding(3, 4, 3, 4);
            approvalDropDownPanel.MaximumSize = new Size(163, 126);
            approvalDropDownPanel.MinimumSize = new Size(163, 41);
            approvalDropDownPanel.Name = "approvalDropDownPanel";
            approvalDropDownPanel.Size = new Size(163, 41);
            approvalDropDownPanel.TabIndex = 6;
            // 
            // changeProfileButton
            // 
            changeProfileButton.BackColor = Color.WhiteSmoke;
            changeProfileButton.Dock = DockStyle.Top;
            changeProfileButton.FlatAppearance.BorderSize = 0;
            changeProfileButton.FlatStyle = FlatStyle.Flat;
            changeProfileButton.Location = new Point(0, 80);
            changeProfileButton.Margin = new Padding(3, 4, 3, 4);
            changeProfileButton.Name = "changeProfileButton";
            changeProfileButton.Padding = new Padding(11, 0, 0, 0);
            changeProfileButton.Size = new Size(161, 45);
            changeProfileButton.TabIndex = 2;
            changeProfileButton.Text = "Change Profile";
            changeProfileButton.TextAlign = ContentAlignment.MiddleLeft;
            changeProfileButton.UseVisualStyleBackColor = false;
            changeProfileButton.Click += changeProfileButton_Click;
            // 
            // changeEmailOption
            // 
            changeEmailOption.BackColor = Color.WhiteSmoke;
            changeEmailOption.Dock = DockStyle.Top;
            changeEmailOption.FlatAppearance.BorderSize = 0;
            changeEmailOption.FlatStyle = FlatStyle.Flat;
            changeEmailOption.Location = new Point(0, 40);
            changeEmailOption.Margin = new Padding(3, 4, 3, 4);
            changeEmailOption.Name = "changeEmailOption";
            changeEmailOption.Padding = new Padding(11, 0, 0, 0);
            changeEmailOption.Size = new Size(161, 40);
            changeEmailOption.TabIndex = 1;
            changeEmailOption.Text = "Change Email";
            changeEmailOption.TextAlign = ContentAlignment.MiddleLeft;
            changeEmailOption.UseVisualStyleBackColor = false;
            changeEmailOption.Click += changeEmailOption_Click;
            // 
            // selectButton
            // 
            selectButton.BackColor = Color.White;
            selectButton.Dock = DockStyle.Top;
            selectButton.FlatAppearance.BorderSize = 0;
            selectButton.FlatStyle = FlatStyle.Flat;
            selectButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectButton.Image = (Image)resources.GetObject("selectButton.Image");
            selectButton.ImageAlign = ContentAlignment.MiddleRight;
            selectButton.Location = new Point(0, 0);
            selectButton.Margin = new Padding(3, 4, 3, 4);
            selectButton.Name = "selectButton";
            selectButton.Padding = new Padding(0, 0, 6, 0);
            selectButton.Size = new Size(161, 40);
            selectButton.TabIndex = 0;
            selectButton.Text = "Select";
            selectButton.TextAlign = ContentAlignment.MiddleLeft;
            selectButton.UseVisualStyleBackColor = false;
            selectButton.Click += selectButton_Click;
            // 
            // requestButton
            // 
            requestButton.BackColor = Color.FromArgb(30, 38, 51);
            requestButton.FlatAppearance.BorderColor = Color.White;
            requestButton.FlatAppearance.BorderSize = 0;
            requestButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 51);
            requestButton.FlatStyle = FlatStyle.Flat;
            requestButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            requestButton.ForeColor = Color.White;
            requestButton.Location = new Point(103, 199);
            requestButton.Margin = new Padding(3, 4, 3, 4);
            requestButton.Name = "requestButton";
            requestButton.Size = new Size(123, 49);
            requestButton.TabIndex = 5;
            requestButton.Text = "REQUEST";
            requestButton.UseVisualStyleBackColor = false;
            requestButton.MouseLeave += LeaveHoverButton;
            requestButton.MouseHover += HoverRequestButton;
            // 
            // approvalDirectionLabel
            // 
            approvalDirectionLabel.AutoSize = true;
            approvalDirectionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            approvalDirectionLabel.Location = new Point(26, 56);
            approvalDirectionLabel.Name = "approvalDirectionLabel";
            approvalDirectionLabel.Size = new Size(277, 56);
            approvalDirectionLabel.TabIndex = 5;
            approvalDirectionLabel.Text = "Select the request you wish to \r\nsend to the admin.";
            approvalDirectionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // approvalLabel
            // 
            approvalLabel.AutoSize = true;
            approvalLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            approvalLabel.Location = new Point(94, 13);
            approvalLabel.Name = "approvalLabel";
            approvalLabel.Size = new Size(144, 37);
            approvalLabel.TabIndex = 5;
            approvalLabel.Text = "APPROVAL";
            // 
            // joinClassPanel
            // 
            joinClassPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            joinClassPanel.BackColor = Color.Transparent;
            joinClassPanel.BackgroundImage = (Image)resources.GetObject("joinClassPanel.BackgroundImage");
            joinClassPanel.BackgroundImageLayout = ImageLayout.Zoom;
            joinClassPanel.Controls.Add(logOutButton);
            joinClassPanel.Controls.Add(userButton);
            joinClassPanel.Controls.Add(label1);
            joinClassPanel.Controls.Add(submitButton);
            joinClassPanel.Controls.Add(codeLabel);
            joinClassPanel.Controls.Add(textBox1);
            joinClassPanel.Controls.Add(joinClassLabel);
            joinClassPanel.Location = new Point(929, 102);
            joinClassPanel.Margin = new Padding(3, 4, 3, 4);
            joinClassPanel.Name = "joinClassPanel";
            joinClassPanel.Size = new Size(326, 256);
            joinClassPanel.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 48);
            label1.Name = "label1";
            label1.Size = new Size(207, 56);
            label1.TabIndex = 7;
            label1.Text = "Paste the class code to\r\njoin class.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // submitButton
            // 
            submitButton.BackColor = Color.FromArgb(30, 38, 51);
            submitButton.FlatAppearance.BorderColor = Color.White;
            submitButton.FlatAppearance.BorderSize = 0;
            submitButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 38, 51);
            submitButton.FlatStyle = FlatStyle.Flat;
            submitButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            submitButton.ForeColor = Color.White;
            submitButton.Location = new Point(103, 187);
            submitButton.Margin = new Padding(3, 4, 3, 4);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(123, 49);
            submitButton.TabIndex = 3;
            submitButton.Text = "SUBMIT";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.MouseLeave += LeaveHoverButton;
            submitButton.MouseHover += HoverSubmitButton;
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            codeLabel.Location = new Point(65, 169);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new Size(0, 28);
            codeLabel.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(81, 132);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 27);
            textBox1.TabIndex = 1;
            // 
            // joinClassLabel
            // 
            joinClassLabel.AutoSize = true;
            joinClassLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            joinClassLabel.Location = new Point(93, 11);
            joinClassLabel.Name = "joinClassLabel";
            joinClassLabel.Size = new Size(157, 37);
            joinClassLabel.TabIndex = 0;
            joinClassLabel.Text = "JOIN CLASS";
            // 
            // welcomePanel
            // 
            welcomePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            welcomePanel.BackColor = Color.Transparent;
            welcomePanel.BackgroundImage = (Image)resources.GetObject("welcomePanel.BackgroundImage");
            welcomePanel.BackgroundImageLayout = ImageLayout.Stretch;
            welcomePanel.Controls.Add(accesslabel);
            welcomePanel.Controls.Add(introlabel);
            welcomePanel.Controls.Add(handwavepicturebox);
            welcomePanel.Controls.Add(WelcomeLabel);
            welcomePanel.Location = new Point(312, 36);
            welcomePanel.Margin = new Padding(3, 4, 3, 4);
            welcomePanel.Name = "welcomePanel";
            welcomePanel.Size = new Size(595, 595);
            welcomePanel.TabIndex = 1;
            // 
            // accesslabel
            // 
            accesslabel.AutoSize = true;
            accesslabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accesslabel.Location = new Point(57, 237);
            accesslabel.Name = "accesslabel";
            accesslabel.Size = new Size(46, 256);
            accesslabel.TabIndex = 3;
            accesslabel.Text = "bla\r\nbla\r\nbla\r\nbla\r\nbla\r\nbla\r\nbla\r\nbla";
            // 
            // introlabel
            // 
            introlabel.AutoSize = true;
            introlabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            introlabel.Location = new Point(21, 125);
            introlabel.Name = "introlabel";
            introlabel.Size = new Size(431, 96);
            introlabel.TabIndex = 2;
            introlabel.Text = "You’re currently log in as a STUDENT. \r\nBelow are the list of features you have \r\naccess with:";
            // 
            // handwavepicturebox
            // 
            handwavepicturebox.BackgroundImage = (Image)resources.GetObject("handwavepicturebox.BackgroundImage");
            handwavepicturebox.BackgroundImageLayout = ImageLayout.Center;
            handwavepicturebox.Location = new Point(57, 24);
            handwavepicturebox.Margin = new Padding(3, 4, 3, 4);
            handwavepicturebox.Name = "handwavepicturebox";
            handwavepicturebox.Size = new Size(81, 93);
            handwavepicturebox.TabIndex = 1;
            handwavepicturebox.TabStop = false;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WelcomeLabel.Location = new Point(144, 51);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(279, 37);
            WelcomeLabel.TabIndex = 0;
            WelcomeLabel.Text = "Welcome, {username}!";
            // 
            // classesPanel
            // 
            classesPanel.BackColor = Color.Transparent;
            classesPanel.BackgroundImage = (Image)resources.GetObject("classesPanel.BackgroundImage");
            classesPanel.BackgroundImageLayout = ImageLayout.Stretch;
            classesPanel.Controls.Add(button1);
            classesPanel.Controls.Add(panel1);
            classesPanel.Location = new Point(32, 36);
            classesPanel.Margin = new Padding(3, 4, 3, 4);
            classesPanel.Name = "classesPanel";
            classesPanel.Size = new Size(258, 525);
            classesPanel.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(0, 73);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(258, 37);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(classesLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 73);
            panel1.TabIndex = 1;
            // 
            // classesLabel
            // 
            classesLabel.AutoSize = true;
            classesLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            classesLabel.Location = new Point(70, 20);
            classesLabel.Name = "classesLabel";
            classesLabel.Size = new Size(121, 37);
            classesLabel.TabIndex = 0;
            classesLabel.Text = "CLASSES";
            // 
            // approvalDropDownTimer
            // 
            approvalDropDownTimer.Tick += timer1_Tick;
            // 
            // logOutButton
            // 
            logOutButton.BackColor = Color.Transparent;
            logOutButton.FlatAppearance.BorderColor = Color.White;
            logOutButton.FlatAppearance.BorderSize = 0;
            logOutButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            logOutButton.FlatStyle = FlatStyle.Flat;
            logOutButton.ForeColor = Color.White;
            logOutButton.Image = (Image)resources.GetObject("logOutButton.Image");
            logOutButton.Location = new Point(16, -20);
            logOutButton.Margin = new Padding(0);
            logOutButton.MaximumSize = new Size(93, 91);
            logOutButton.MinimumSize = new Size(93, 91);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(93, 91);
            logOutButton.TabIndex = 0;
            logOutButton.UseVisualStyleBackColor = false;
            logOutButton.Click += logOutButton_Click;
            logOutButton.MouseLeave += LeaveHoverButton;
            logOutButton.MouseHover += HoverLogOutButton;
            // 
            // userButton
            // 
            userButton.BackColor = Color.Transparent;
            userButton.FlatAppearance.BorderColor = Color.White;
            userButton.FlatAppearance.BorderSize = 0;
            userButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            userButton.FlatStyle = FlatStyle.Flat;
            userButton.ForeColor = Color.White;
            userButton.Image = (Image)resources.GetObject("userButton.Image");
            userButton.Location = new Point(145, -42);
            userButton.Margin = new Padding(0);
            userButton.MaximumSize = new Size(93, 91);
            userButton.MinimumSize = new Size(93, 91);
            userButton.Name = "userButton";
            userButton.Size = new Size(93, 91);
            userButton.TabIndex = 1;
            userButton.UseVisualStyleBackColor = false;
            userButton.MouseLeave += LeaveHoverButton;
            userButton.MouseHover += HoverUserButton;
            // 
            // homeButton
            // 
            homeButton.BackColor = Color.FromArgb(210, 210, 210);
            homeButton.FlatAppearance.BorderColor = Color.White;
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 210, 210);
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.ForeColor = Color.White;
            homeButton.Image = (Image)resources.GetObject("homeButton.Image");
            homeButton.Location = new Point(1299, -1);
            homeButton.Margin = new Padding(0);
            homeButton.MaximumSize = new Size(93, 92);
            homeButton.MinimumSize = new Size(93, 92);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(93, 92);
            homeButton.TabIndex = 3;
            homeButton.Text = "\r\n";
            homeButton.UseVisualStyleBackColor = false;
            homeButton.MouseLeave += LeaveHoverButton;
            homeButton.MouseHover += HoverHomeButton;
            // 
            // notifButton
            // 
            notifButton.BackColor = Color.Transparent;
            notifButton.FlatAppearance.BorderColor = Color.White;
            notifButton.FlatAppearance.BorderSize = 0;
            notifButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            notifButton.FlatStyle = FlatStyle.Flat;
            notifButton.ForeColor = Color.White;
            notifButton.Image = (Image)resources.GetObject("notifButton.Image");
            notifButton.Location = new Point(1206, 0);
            notifButton.Margin = new Padding(0);
            notifButton.MaximumSize = new Size(93, 91);
            notifButton.MinimumSize = new Size(93, 91);
            notifButton.Name = "notifButton";
            notifButton.Size = new Size(93, 91);
            notifButton.TabIndex = 2;
            notifButton.Text = "\r\n";
            notifButton.UseVisualStyleBackColor = false;
            notifButton.MouseLeave += LeaveHoverButton;
            notifButton.MouseHover += HoverNotifButton;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1518, 815);
            Controls.Add(homeButton);
            Controls.Add(containerPanel);
            Controls.Add(notifButton);
            Controls.Add(titleLabel);
            Controls.Add(SideMenuBar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1536, 862);
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CMS";
            SideMenuBar.ResumeLayout(false);
            rolePanel.ResumeLayout(false);
            rolePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilePic).EndInit();
            LogoHoderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoHolderPictureBox).EndInit();
            containerPanel.ResumeLayout(false);
            approvePanel.ResumeLayout(false);
            approvePanel.PerformLayout();
            approvalDropDownPanel.ResumeLayout(false);
            joinClassPanel.ResumeLayout(false);
            joinClassPanel.PerformLayout();
            welcomePanel.ResumeLayout(false);
            welcomePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)handwavepicturebox).EndInit();
            classesPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel SideMenuBar;
        private Panel LogoHoderPanel;
        private Button MenuButton;
        private PictureBox logoHolderPictureBox;
        private Panel rolePanel;
        private PictureBox ProfilePic;
        private Label roleLabel;
        private Panel ClassesDropDownPanel;
        private Button ClassesButton;
        private Label username;
        private Label email;
        private Label titleLabel;
        private Panel containerPanel;
        private Panel classesPanel;
        private Panel welcomePanel;
        private Panel approvePanel;
        private Panel joinClassPanel;
        private Label WelcomeLabel;
        private Label classesLabel;
        private Label codeLabel;
        private TextBox textBox1;
        private Label joinClassLabel;
        private Label accesslabel;
        private Label introlabel;
        private PictureBox handwavepicturebox;
        private Label approvalLabel;
        private ClassroomManagementSystem.Custom.CustomButton submitButton;
        private ClassroomManagementSystem.Custom.CustomButton requestButton;
        private Label approvalDirectionLabel;
        private Panel panel1;
        private Panel approvalDropDownPanel;
        private Button changeEmailOption;
        private Button selectButton;
        private Button changeProfileButton;
        private System.Windows.Forms.Timer approvalDropDownTimer;
        private Button button1;
        private Label label1;
        private ClassroomManagementSystem.Custom.CustomButton logOutButton;
        private ClassroomManagementSystem.Custom.CustomButton userButton;
        private ClassroomManagementSystem.Custom.CustomButton homeButton;
        private ClassroomManagementSystem.Custom.CustomButton notifButton;
    }
}