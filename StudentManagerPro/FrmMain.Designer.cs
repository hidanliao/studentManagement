namespace StudentManagerPro
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_PwdModify = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加学员AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importStudentsInBatchesIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.studentInformationManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.spContainer = new System.Windows.Forms.SplitContainer();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnStuManage = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).BeginInit();
            this.spContainer.Panel1.SuspendLayout();
            this.spContainer.Panel2.SuspendLayout();
            this.spContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.studentManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_PwdModify,
            this.toolStripSeparator1,
            this.exitSystemToolStripMenuItem});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.系统ToolStripMenuItem.Text = "System(&S)";
            // 
            // tsmi_PwdModify
            // 
            this.tsmi_PwdModify.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_PwdModify.Image")));
            this.tsmi_PwdModify.Name = "tsmi_PwdModify";
            this.tsmi_PwdModify.Size = new System.Drawing.Size(186, 22);
            this.tsmi_PwdModify.Text = "Change password(&M)";
            this.tsmi_PwdModify.Click += new System.EventHandler(this.tsmi_PwdModify_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // exitSystemToolStripMenuItem
            // 
            this.exitSystemToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitSystemToolStripMenuItem.Image")));
            this.exitSystemToolStripMenuItem.Name = "exitSystemToolStripMenuItem";
            this.exitSystemToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitSystemToolStripMenuItem.Text = "Exit system";
            // 
            // studentManagementToolStripMenuItem
            // 
            this.studentManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加学员AToolStripMenuItem,
            this.importStudentsInBatchesIToolStripMenuItem,
            this.toolStripSeparator2,
            this.studentInformationManagementToolStripMenuItem});
            this.studentManagementToolStripMenuItem.Name = "studentManagementToolStripMenuItem";
            this.studentManagementToolStripMenuItem.Size = new System.Drawing.Size(151, 20);
            this.studentManagementToolStripMenuItem.Text = "Student management(&M)";
            // 
            // 添加学员AToolStripMenuItem
            // 
            this.添加学员AToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("添加学员AToolStripMenuItem.Image")));
            this.添加学员AToolStripMenuItem.Name = "添加学员AToolStripMenuItem";
            this.添加学员AToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.添加学员AToolStripMenuItem.Text = "Add students(&A)";
            // 
            // importStudentsInBatchesIToolStripMenuItem
            // 
            this.importStudentsInBatchesIToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("importStudentsInBatchesIToolStripMenuItem.Image")));
            this.importStudentsInBatchesIToolStripMenuItem.Name = "importStudentsInBatchesIToolStripMenuItem";
            this.importStudentsInBatchesIToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.importStudentsInBatchesIToolStripMenuItem.Text = "Import students in batches(&I)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(249, 6);
            // 
            // studentInformationManagementToolStripMenuItem
            // 
            this.studentInformationManagementToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("studentInformationManagementToolStripMenuItem.Image")));
            this.studentInformationManagementToolStripMenuItem.Name = "studentInformationManagementToolStripMenuItem";
            this.studentInformationManagementToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.studentInformationManagementToolStripMenuItem.Text = "Student information management";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 707);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1264, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(117, 17);
            this.toolStripStatusLabel1.Text = "Version number: V2.0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(139, 17);
            this.toolStripStatusLabel2.Text = "             [Current user: ***]";
            // 
            // spContainer
            // 
            this.spContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spContainer.Location = new System.Drawing.Point(0, 24);
            this.spContainer.Name = "spContainer";
            // 
            // spContainer.Panel1
            // 
            this.spContainer.Panel1.Controls.Add(this.button8);
            this.spContainer.Panel1.Controls.Add(this.button6);
            this.spContainer.Panel1.Controls.Add(this.button4);
            this.spContainer.Panel1.Controls.Add(this.button2);
            this.spContainer.Panel1.Controls.Add(this.button7);
            this.spContainer.Panel1.Controls.Add(this.button5);
            this.spContainer.Panel1.Controls.Add(this.btnStuManage);
            this.spContainer.Panel1.Controls.Add(this.btnAddStudent);
            this.spContainer.Panel1.Controls.Add(this.monthCalendar1);
            // 
            // spContainer.Panel2
            // 
            this.spContainer.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("spContainer.Panel2.BackgroundImage")));
            this.spContainer.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spContainer.Panel2.Controls.Add(this.label1);
            this.spContainer.Size = new System.Drawing.Size(1264, 683);
            this.spContainer.SplitterDistance = 228;
            this.spContainer.TabIndex = 2;
            // 
            // button8
            // 
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(121, 625);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(93, 28);
            this.button8.TabIndex = 1;
            this.button8.Text = "Exit";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(121, 297);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 28);
            this.button6.TabIndex = 1;
            this.button6.Text = "Results";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(121, 251);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 28);
            this.button4.TabIndex = 1;
            this.button4.Text = "Attendance";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(121, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Import";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(15, 625);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(93, 28);
            this.button7.TabIndex = 1;
            this.button7.Text = "Password";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(15, 297);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 28);
            this.button5.TabIndex = 1;
            this.button5.Text = "Analyze";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnStuManage
            // 
            this.btnStuManage.Image = ((System.Drawing.Image)(resources.GetObject("btnStuManage.Image")));
            this.btnStuManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStuManage.Location = new System.Drawing.Point(15, 251);
            this.btnStuManage.Name = "btnStuManage";
            this.btnStuManage.Size = new System.Drawing.Size(93, 28);
            this.btnStuManage.TabIndex = 1;
            this.btnStuManage.Text = "Management";
            this.btnStuManage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStuManage.UseVisualStyleBackColor = true;
            this.btnStuManage.Click += new System.EventHandler(this.btnStuManage_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStudent.Image")));
            this.btnAddStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStudent.Location = new System.Drawing.Point(15, 203);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(93, 28);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(15, 12);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ac_plug.ico");
            this.imageList1.Images.SetKeyName(1, "accesibility_window_abc.ico");
            this.imageList1.Images.SetKeyName(2, "access_wheelchair_big.ico");
            this.imageList1.Images.SetKeyName(3, "accessibility.ico");
            this.imageList1.Images.SetKeyName(4, "accessibility_big_keys.ico");
            this.imageList1.Images.SetKeyName(5, "accessibility_contrast.ico");
            this.imageList1.Images.SetKeyName(6, "accessibility_kbd_mouse.ico");
            this.imageList1.Images.SetKeyName(7, "accessibility_key_pointer.ico");
            this.imageList1.Images.SetKeyName(8, "accessibility_stopwatch.ico");
            this.imageList1.Images.SetKeyName(9, "accessibility_toggle.ico");
            this.imageList1.Images.SetKeyName(10, "accessibility_toggle2.ico");
            this.imageList1.Images.SetKeyName(11, "accessibility_toggle3.ico");
            this.imageList1.Images.SetKeyName(12, "accessibility_two_windows.ico");
            this.imageList1.Images.SetKeyName(13, "accessibility_window_objs.ico");
            this.imageList1.Images.SetKeyName(14, "accessibility_window_signal.ico");
            this.imageList1.Images.SetKeyName(15, "accessibility_window_speak.ico");
            this.imageList1.Images.SetKeyName(16, "active_movie.ico");
            this.imageList1.Images.SetKeyName(17, "address_book.ico");
            this.imageList1.Images.SetKeyName(18, "address_book_card.ico");
            this.imageList1.Images.SetKeyName(19, "address_book_card_copy.ico");
            this.imageList1.Images.SetKeyName(20, "address_book_card_users.ico");
            this.imageList1.Images.SetKeyName(21, "address_book_cards.ico");
            this.imageList1.Images.SetKeyName(22, "address_book_copy.ico");
            this.imageList1.Images.SetKeyName(23, "address_book_home.ico");
            this.imageList1.Images.SetKeyName(24, "address_book_pad.ico");
            this.imageList1.Images.SetKeyName(25, "address_book_pad_users.ico");
            this.imageList1.Images.SetKeyName(26, "address_book_user.ico");
            this.imageList1.Images.SetKeyName(27, "address_book_users.ico");
            this.imageList1.Images.SetKeyName(28, "amplify.ico");
            this.imageList1.Images.SetKeyName(29, "application_hammer_grouppol.ico");
            this.imageList1.Images.SetKeyName(30, "application_hourglass.ico");
            this.imageList1.Images.SetKeyName(31, "application_hourglass_small.ico");
            this.imageList1.Images.SetKeyName(32, "application_hourglass_small_cool.ico");
            this.imageList1.Images.SetKeyName(33, "appwiz_file.ico");
            this.imageList1.Images.SetKeyName(34, "appwizard.ico");
            this.imageList1.Images.SetKeyName(35, "appwizard_list.ico");
            this.imageList1.Images.SetKeyName(36, "audio_compression.ico");
            this.imageList1.Images.SetKeyName(37, "backup_devices.ico");
            this.imageList1.Images.SetKeyName(38, "backup_devices_2.ico");
            this.imageList1.Images.SetKeyName(39, "bar_graph.ico");
            this.imageList1.Images.SetKeyName(40, "bar_graph_default.ico");
            this.imageList1.Images.SetKeyName(41, "battery.ico");
            this.imageList1.Images.SetKeyName(42, "battery_alt.ico");
            this.imageList1.Images.SetKeyName(43, "briefcase.ico");
            this.imageList1.Images.SetKeyName(44, "cable.ico");
            this.imageList1.Images.SetKeyName(45, "cable_2.ico");
            this.imageList1.Images.SetKeyName(46, "cable_3.ico");
            this.imageList1.Images.SetKeyName(47, "calculator.ico");
            this.imageList1.Images.SetKeyName(48, "calendar.ico");
            this.imageList1.Images.SetKeyName(49, "calendar2.ico");
            this.imageList1.Images.SetKeyName(50, "camera.ico");
            this.imageList1.Images.SetKeyName(51, "camera_2.ico");
            this.imageList1.Images.SetKeyName(52, "camera_vid.ico");
            this.imageList1.Images.SetKeyName(53, "camera_vid_ms.ico");
            this.imageList1.Images.SetKeyName(54, "camera3.ico");
            this.imageList1.Images.SetKeyName(55, "camera3_network.ico");
            this.imageList1.Images.SetKeyName(56, "camera3_plus.ico");
            this.imageList1.Images.SetKeyName(57, "camera3_vid.ico");
            this.imageList1.Images.SetKeyName(58, "card_reader.ico");
            this.imageList1.Images.SetKeyName(59, "card_reader_empty.ico");
            this.imageList1.Images.SetKeyName(60, "card_reader_not.ico");
            this.imageList1.Images.SetKeyName(61, "card_reader_restr.ico");
            this.imageList1.Images.SetKeyName(62, "cardfile.ico");
            this.imageList1.Images.SetKeyName(63, "cassette_tape.ico");
            this.imageList1.Images.SetKeyName(64, "catalog.ico");
            this.imageList1.Images.SetKeyName(65, "catalog_excl.ico");
            this.imageList1.Images.SetKeyName(66, "catalog_no.ico");
            this.imageList1.Images.SetKeyName(67, "c-clamp.ico");
            this.imageList1.Images.SetKeyName(68, "cd_audio_cd.ico");
            this.imageList1.Images.SetKeyName(69, "cd_audio_cd_a.ico");
            this.imageList1.Images.SetKeyName(70, "cd_drive.ico");
            this.imageList1.Images.SetKeyName(71, "cd_drive_purple.ico");
            this.imageList1.Images.SetKeyName(72, "certificate.ico");
            this.imageList1.Images.SetKeyName(73, "certificate_2.ico");
            this.imageList1.Images.SetKeyName(74, "certificate_2_excl.ico");
            this.imageList1.Images.SetKeyName(75, "certificate_2_no.ico");
            this.imageList1.Images.SetKeyName(76, "certificate_3.ico");
            this.imageList1.Images.SetKeyName(77, "certificate_application.ico");
            this.imageList1.Images.SetKeyName(78, "certificate_checklist.ico");
            this.imageList1.Images.SetKeyName(79, "certificate_envelope_key.ico");
            this.imageList1.Images.SetKeyName(80, "certificate_excl.ico");
            this.imageList1.Images.SetKeyName(81, "certificate_gear.ico");
            this.imageList1.Images.SetKeyName(82, "certificate_multiple.ico");
            this.imageList1.Images.SetKeyName(83, "certificate_no.ico");
            this.imageList1.Images.SetKeyName(84, "certificate_red_line.ico");
            this.imageList1.Images.SetKeyName(85, "certificate_seal.ico");
            this.imageList1.Images.SetKeyName(86, "certificate_seal_lock.ico");
            this.imageList1.Images.SetKeyName(87, "certificate_server.ico");
            this.imageList1.Images.SetKeyName(88, "channels.ico");
            this.imageList1.Images.SetKeyName(89, "channels_file.ico");
            this.imageList1.Images.SetKeyName(90, "charmap.ico");
            this.imageList1.Images.SetKeyName(91, "charmap_w2k.ico");
            this.imageList1.Images.SetKeyName(92, "chart1.ico");
            this.imageList1.Images.SetKeyName(93, "check.ico");
            this.imageList1.Images.SetKeyName(94, "chip_ramdrive.ico");
            this.imageList1.Images.SetKeyName(95, "chm.ico");
            this.imageList1.Images.SetKeyName(96, "circle_question.ico");
            this.imageList1.Images.SetKeyName(97, "clean_drive.ico");
            this.imageList1.Images.SetKeyName(98, "clock.ico");
            this.imageList1.Images.SetKeyName(99, "color_profile.ico");
            this.imageList1.Images.SetKeyName(100, "color_profile_gray.ico");
            this.imageList1.Images.SetKeyName(101, "computer.ico");
            this.imageList1.Images.SetKeyName(102, "computer_2.ico");
            this.imageList1.Images.SetKeyName(103, "computer_2_cool.ico");
            this.imageList1.Images.SetKeyName(104, "computer_explorer.ico");
            this.imageList1.Images.SetKeyName(105, "computer_explorer_2k.ico");
            this.imageList1.Images.SetKeyName(106, "computer_explorer_cool.ico");
            this.imageList1.Images.SetKeyName(107, "computer_gear.ico");
            this.imageList1.Images.SetKeyName(108, "computer_musical_keyboard.ico");
            this.imageList1.Images.SetKeyName(109, "computer_padlock.ico");
            this.imageList1.Images.SetKeyName(110, "computer_search.ico");
            this.imageList1.Images.SetKeyName(111, "computer_sound.ico");
            this.imageList1.Images.SetKeyName(112, "computer_taskmgr.ico");
            this.imageList1.Images.SetKeyName(113, "computer_user_pencil.ico");
            this.imageList1.Images.SetKeyName(114, "computer_win.ico");
            this.imageList1.Images.SetKeyName(115, "computer_win_lock.ico");
            this.imageList1.Images.SetKeyName(116, "conn_cloud.ico");
            this.imageList1.Images.SetKeyName(117, "conn_cloud_ok.ico");
            this.imageList1.Images.SetKeyName(118, "conn_dialup.ico");
            this.imageList1.Images.SetKeyName(119, "conn_dialup_alt.ico");
            this.imageList1.Images.SetKeyName(120, "conn_dialup_ok.ico");
            this.imageList1.Images.SetKeyName(121, "conn_dialup_recbin_phone.ico");
            this.imageList1.Images.SetKeyName(122, "conn_dialup_recbin_phones.ico");
            this.imageList1.Images.SetKeyName(123, "conn_network_no_phone.ico");
            this.imageList1.Images.SetKeyName(124, "conn_pcs_no_network.ico");
            this.imageList1.Images.SetKeyName(125, "conn_pcs_off_off.ico");
            this.imageList1.Images.SetKeyName(126, "conn_pcs_off_on.ico");
            this.imageList1.Images.SetKeyName(127, "conn_pcs_on_off.ico");
            this.imageList1.Images.SetKeyName(128, "conn_pcs_on_on.ico");
            this.imageList1.Images.SetKeyName(129, "connected_world.ico");
            this.imageList1.Images.SetKeyName(130, "console_prompt.ico");
            this.imageList1.Images.SetKeyName(131, "cylinder_database.ico");
            this.imageList1.Images.SetKeyName(132, "defragment.ico");
            this.imageList1.Images.SetKeyName(133, "desktop.ico");
            this.imageList1.Images.SetKeyName(134, "desktop_old.ico");
            this.imageList1.Images.SetKeyName(135, "desktop_w95.ico");
            this.imageList1.Images.SetKeyName(136, "device_rhombic_chip.ico");
            this.imageList1.Images.SetKeyName(137, "direct_cable_conn.ico");
            this.imageList1.Images.SetKeyName(138, "directory_admin_tools.ico");
            this.imageList1.Images.SetKeyName(139, "directory_business_calendar.ico");
            this.imageList1.Images.SetKeyName(140, "directory_channels.ico");
            this.imageList1.Images.SetKeyName(141, "directory_check.ico");
            this.imageList1.Images.SetKeyName(142, "directory_closed.ico");
            this.imageList1.Images.SetKeyName(143, "directory_closed_cool.ico");
            this.imageList1.Images.SetKeyName(144, "directory_closed_history.ico");
            this.imageList1.Images.SetKeyName(145, "directory_computer.ico");
            this.imageList1.Images.SetKeyName(146, "directory_control_panel.ico");
            this.imageList1.Images.SetKeyName(147, "directory_control_panel_cool.ico");
            this.imageList1.Images.SetKeyName(148, "directory_dial-up_networking.ico");
            this.imageList1.Images.SetKeyName(149, "directory_dial-up_networking_cool.ico");
            this.imageList1.Images.SetKeyName(150, "directory_e.ico");
            this.imageList1.Images.SetKeyName(151, "directory_e_open.ico");
            this.imageList1.Images.SetKeyName(152, "directory_explorer.ico");
            this.imageList1.Images.SetKeyName(153, "directory_favorites.ico");
            this.imageList1.Images.SetKeyName(154, "directory_favorites_small.ico");
            this.imageList1.Images.SetKeyName(155, "directory_folder_options.ico");
            this.imageList1.Images.SetKeyName(156, "directory_fonts.ico");
            this.imageList1.Images.SetKeyName(157, "directory_fonts_cool.ico");
            this.imageList1.Images.SetKeyName(158, "directory_fonts_shortcut.ico");
            this.imageList1.Images.SetKeyName(159, "directory_movie.ico");
            this.imageList1.Images.SetKeyName(160, "directory_net_web.ico");
            this.imageList1.Images.SetKeyName(161, "directory_network_conn.ico");
            this.imageList1.Images.SetKeyName(162, "directory_network_conn_shortcut.ico");
            this.imageList1.Images.SetKeyName(163, "directory_open.ico");
            this.imageList1.Images.SetKeyName(164, "directory_open_cabinet.ico");
            this.imageList1.Images.SetKeyName(165, "directory_open_cabinet_fc.ico");
            this.imageList1.Images.SetKeyName(166, "directory_open_cool.ico");
            this.imageList1.Images.SetKeyName(167, "directory_open_file_mydocs.ico");
            this.imageList1.Images.SetKeyName(168, "directory_open_file_mydocs_2k.ico");
            this.imageList1.Images.SetKeyName(169, "directory_open_file_mydocs_cool.ico");
            this.imageList1.Images.SetKeyName(170, "directory_open_file_mydocs_small.ico");
            this.imageList1.Images.SetKeyName(171, "directory_open_history.ico");
            this.imageList1.Images.SetKeyName(172, "directory_open_net_web_documents.ico");
            this.imageList1.Images.SetKeyName(173, "directory_open_network.ico");
            this.imageList1.Images.SetKeyName(174, "directory_open_refresh.ico");
            this.imageList1.Images.SetKeyName(175, "directory_pictures.ico");
            this.imageList1.Images.SetKeyName(176, "directory_printer.ico");
            this.imageList1.Images.SetKeyName(177, "directory_printer_cool.ico");
            this.imageList1.Images.SetKeyName(178, "directory_printer_shortcut.ico");
            this.imageList1.Images.SetKeyName(179, "directory_program_group.ico");
            this.imageList1.Images.SetKeyName(180, "directory_program_group_cool.ico");
            this.imageList1.Images.SetKeyName(181, "directory_program_group_small.ico");
            this.imageList1.Images.SetKeyName(182, "directory_program_group_small_c.ico");
            this.imageList1.Images.SetKeyName(183, "directory_scanner_camera.ico");
            this.imageList1.Images.SetKeyName(184, "directory_sched_tasks.ico");
            this.imageList1.Images.SetKeyName(185, "directory_seven.ico");
            this.imageList1.Images.SetKeyName(186, "directory_shared.ico");
            this.imageList1.Images.SetKeyName(187, "directory_web.ico");
            this.imageList1.Images.SetKeyName(188, "directory_zipper.ico");
            this.imageList1.Images.SetKeyName(189, "directory_zipper_alt.ico");
            this.imageList1.Images.SetKeyName(190, "directx.ico");
            this.imageList1.Images.SetKeyName(191, "directx_alt.ico");
            this.imageList1.Images.SetKeyName(192, "diskettes_copy.ico");
            this.imageList1.Images.SetKeyName(193, "display_properties.ico");
            this.imageList1.Images.SetKeyName(194, "doctor_watson.ico");
            this.imageList1.Images.SetKeyName(195, "document.ico");
            this.imageList1.Images.SetKeyName(196, "download.ico");
            this.imageList1.Images.SetKeyName(197, "drum_onestick.ico");
            this.imageList1.Images.SetKeyName(198, "eject_pc.ico");
            this.imageList1.Images.SetKeyName(199, "eject_pc_2.ico");
            this.imageList1.Images.SetKeyName(200, "eject_pc_cool.ico");
            this.imageList1.Images.SetKeyName(201, "eject_pc_shell32.ico");
            this.imageList1.Images.SetKeyName(202, "entire_network_globe.ico");
            this.imageList1.Images.SetKeyName(203, "envelope_closed.ico");
            this.imageList1.Images.SetKeyName(204, "envelope_open_sheet.ico");
            this.imageList1.Images.SetKeyName(205, "erase_file.ico");
            this.imageList1.Images.SetKeyName(206, "event_log.ico");
            this.imageList1.Images.SetKeyName(207, "executable.ico");
            this.imageList1.Images.SetKeyName(208, "executable_gear.ico");
            this.imageList1.Images.SetKeyName(209, "executable_script.ico");
            this.imageList1.Images.SetKeyName(210, "executable_sound.ico");
            this.imageList1.Images.SetKeyName(211, "expand_hierarchial_array.ico");
            this.imageList1.Images.SetKeyName(212, "expansion_board.ico");
            this.imageList1.Images.SetKeyName(213, "expansion_board_modem.ico");
            this.imageList1.Images.SetKeyName(214, "fax_machine.ico");
            this.imageList1.Images.SetKeyName(215, "fax_machine_exclam.ico");
            this.imageList1.Images.SetKeyName(216, "fax_machine_paperstack.ico");
            this.imageList1.Images.SetKeyName(217, "file_blue_grad_paint.ico");
            this.imageList1.Images.SetKeyName(218, "file_cd.ico");
            this.imageList1.Images.SetKeyName(219, "file_eye.ico");
            this.imageList1.Images.SetKeyName(220, "file_gears.ico");
            this.imageList1.Images.SetKeyName(221, "file_lines.ico");
            this.imageList1.Images.SetKeyName(222, "file_padlock.ico");
            this.imageList1.Images.SetKeyName(223, "file_program_group.ico");
            this.imageList1.Images.SetKeyName(224, "file_question.ico");
            this.imageList1.Images.SetKeyName(225, "file_set.ico");
            this.imageList1.Images.SetKeyName(226, "file_sorted_lock.ico");
            this.imageList1.Images.SetKeyName(227, "file_win_shortcut.ico");
            this.imageList1.Images.SetKeyName(228, "file_windows.ico");
            this.imageList1.Images.SetKeyName(229, "filepack.ico");
            this.imageList1.Images.SetKeyName(230, "floppy_drive_3-5.ico");
            this.imageList1.Images.SetKeyName(231, "floppy_drive_3-5_cool.ico");
            this.imageList1.Images.SetKeyName(232, "floppy_drive_5-25.ico");
            this.imageList1.Images.SetKeyName(233, "floppy_drive_5-25_cool.ico");
            this.imageList1.Images.SetKeyName(234, "font_adobe.ico");
            this.imageList1.Images.SetKeyName(235, "font_bitmap.ico");
            this.imageList1.Images.SetKeyName(236, "font_opentype.ico");
            this.imageList1.Images.SetKeyName(237, "font_tt.ico");
            this.imageList1.Images.SetKeyName(238, "font_tt_green.ico");
            this.imageList1.Images.SetKeyName(239, "frame_web.ico");
            this.imageList1.Images.SetKeyName(240, "game_freecell.ico");
            this.imageList1.Images.SetKeyName(241, "game_hearts.ico");
            this.imageList1.Images.SetKeyName(242, "game_mine_1.ico");
            this.imageList1.Images.SetKeyName(243, "game_mine_2.ico");
            this.imageList1.Images.SetKeyName(244, "game_solitaire.ico");
            this.imageList1.Images.SetKeyName(245, "game_spider.ico");
            this.imageList1.Images.SetKeyName(246, "gears.ico");
            this.imageList1.Images.SetKeyName(247, "gears_3.ico");
            this.imageList1.Images.SetKeyName(248, "gears_tweakui_a.ico");
            this.imageList1.Images.SetKeyName(249, "gears_tweakui_b.ico");
            this.imageList1.Images.SetKeyName(250, "globe_map.ico");
            this.imageList1.Images.SetKeyName(251, "gps.ico");
            this.imageList1.Images.SetKeyName(252, "graphedit.ico");
            this.imageList1.Images.SetKeyName(253, "graphedit_file.ico");
            this.imageList1.Images.SetKeyName(254, "graphedit_file_2.ico");
            this.imageList1.Images.SetKeyName(255, "hard_disk_drive.ico");
            this.imageList1.Images.SetKeyName(256, "hard_disk_drive_cool.ico");
            this.imageList1.Images.SetKeyName(257, "hard_disk_drive_pie.ico");
            this.imageList1.Images.SetKeyName(258, "hard_disk_drive_tools.ico");
            this.imageList1.Images.SetKeyName(259, "hard_disk_drives.ico");
            this.imageList1.Images.SetKeyName(260, "hardware.ico");
            this.imageList1.Images.SetKeyName(261, "help_book_big.ico");
            this.imageList1.Images.SetKeyName(262, "help_book_computer.ico");
            this.imageList1.Images.SetKeyName(263, "help_book_cool.ico");
            this.imageList1.Images.SetKeyName(264, "help_book_cool_small.ico");
            this.imageList1.Images.SetKeyName(265, "help_book_small.ico");
            this.imageList1.Images.SetKeyName(266, "help_question_mark.ico");
            this.imageList1.Images.SetKeyName(267, "help_sheet.ico");
            this.imageList1.Images.SetKeyName(268, "history.ico");
            this.imageList1.Images.SetKeyName(269, "homepage.ico");
            this.imageList1.Images.SetKeyName(270, "homepage_alt.ico");
            this.imageList1.Images.SetKeyName(271, "html.ico");
            this.imageList1.Images.SetKeyName(272, "html2.ico");
            this.imageList1.Images.SetKeyName(273, "html2_new.ico");
            this.imageList1.Images.SetKeyName(274, "image_old_gif.ico");
            this.imageList1.Images.SetKeyName(275, "image_old_jpeg.ico");
            this.imageList1.Images.SetKeyName(276, "imagGIF.ico");
            this.imageList1.Images.SetKeyName(277, "imagJPEG.ico");
            this.imageList1.Images.SetKeyName(278, "imagKoda.ico");
            this.imageList1.Images.SetKeyName(279, "imagOthe.ico");
            this.imageList1.Images.SetKeyName(280, "imagPNG.ico");
            this.imageList1.Images.SetKeyName(281, "imagWMF.ico");
            this.imageList1.Images.SetKeyName(282, "infrared.ico");
            this.imageList1.Images.SetKeyName(283, "input_devices.ico");
            this.imageList1.Images.SetKeyName(284, "installer.ico");
            this.imageList1.Images.SetKeyName(285, "installer_file_gear.ico");
            this.imageList1.Images.SetKeyName(286, "installer_generic_old.ico");
            this.imageList1.Images.SetKeyName(287, "internet_connection_wiz.ico");
            this.imageList1.Images.SetKeyName(288, "internet_options.ico");
            this.imageList1.Images.SetKeyName(289, "internet_options_old_e.ico");
            this.imageList1.Images.SetKeyName(290, "ipconfig.ico");
            this.imageList1.Images.SetKeyName(291, "java.ico");
            this.imageList1.Images.SetKeyName(292, "java_dpf.ico");
            this.imageList1.Images.SetKeyName(293, "java_ocx.ico");
            this.imageList1.Images.SetKeyName(294, "joystick.ico");
            this.imageList1.Images.SetKeyName(295, "joystick_alt.ico");
            this.imageList1.Images.SetKeyName(296, "joystick_button.ico");
            this.imageList1.Images.SetKeyName(297, "key_gray.ico");
            this.imageList1.Images.SetKeyName(298, "key_padlock.ico");
            this.imageList1.Images.SetKeyName(299, "key_padlock_help.ico");
            this.imageList1.Images.SetKeyName(300, "key_webfile.ico");
            this.imageList1.Images.SetKeyName(301, "key_win.ico");
            this.imageList1.Images.SetKeyName(302, "key_win_alt.ico");
            this.imageList1.Images.SetKeyName(303, "key_world.ico");
            this.imageList1.Images.SetKeyName(304, "keyboard.ico");
            this.imageList1.Images.SetKeyName(305, "keyboard_delay.ico");
            this.imageList1.Images.SetKeyName(306, "keyboard_musical.ico");
            this.imageList1.Images.SetKeyName(307, "keyboard_musical_midi.ico");
            this.imageList1.Images.SetKeyName(308, "keyboard_repeat_rate.ico");
            this.imageList1.Images.SetKeyName(309, "keys.ico");
            this.imageList1.Images.SetKeyName(310, "kodak_imaging.ico");
            this.imageList1.Images.SetKeyName(311, "kodak_imaging_file.ico");
            this.imageList1.Images.SetKeyName(312, "laptop.ico");
            this.imageList1.Images.SetKeyName(313, "laptop_infrared.ico");
            this.imageList1.Images.SetKeyName(314, "laptop_infrared_2.ico");
            this.imageList1.Images.SetKeyName(315, "laptop_small.ico");
            this.imageList1.Images.SetKeyName(316, "loudspeaker_muted.ico");
            this.imageList1.Images.SetKeyName(317, "loudspeaker_rays.ico");
            this.imageList1.Images.SetKeyName(318, "loudspeaker_rays_green.ico");
            this.imageList1.Images.SetKeyName(319, "loudspeaker_wave.ico");
            this.imageList1.Images.SetKeyName(320, "magnifying_glass.ico");
            this.imageList1.Images.SetKeyName(321, "magnifying_glass_3.ico");
            this.imageList1.Images.SetKeyName(322, "magnifying_glass_4.ico");
            this.imageList1.Images.SetKeyName(323, "mailbox_world.ico");
            this.imageList1.Images.SetKeyName(324, "mci_devices.ico");
            this.imageList1.Images.SetKeyName(325, "media_player.ico");
            this.imageList1.Images.SetKeyName(326, "media_player_file.ico");
            this.imageList1.Images.SetKeyName(327, "media_player_stream_conn1.ico");
            this.imageList1.Images.SetKeyName(328, "media_player_stream_conn2.ico");
            this.imageList1.Images.SetKeyName(329, "media_player_stream_mono.ico");
            this.imageList1.Images.SetKeyName(330, "media_player_stream_no.ico");
            this.imageList1.Images.SetKeyName(331, "media_player_stream_no2.ico");
            this.imageList1.Images.SetKeyName(332, "media_player_stream_stereo.ico");
            this.imageList1.Images.SetKeyName(333, "media_player_stream_sun0.ico");
            this.imageList1.Images.SetKeyName(334, "media_player_stream_sun1.ico");
            this.imageList1.Images.SetKeyName(335, "media_player_stream_sun2.ico");
            this.imageList1.Images.SetKeyName(336, "media_player_stream_sun3.ico");
            this.imageList1.Images.SetKeyName(337, "media_player_stream_sun4.ico");
            this.imageList1.Images.SetKeyName(338, "memory.ico");
            this.imageList1.Images.SetKeyName(339, "message_empty_tack.ico");
            this.imageList1.Images.SetKeyName(340, "message_envelope_open.ico");
            this.imageList1.Images.SetKeyName(341, "message_file.ico");
            this.imageList1.Images.SetKeyName(342, "message_tack.ico");
            this.imageList1.Images.SetKeyName(343, "microphone.ico");
            this.imageList1.Images.SetKeyName(344, "microphone_2.ico");
            this.imageList1.Images.SetKeyName(345, "midi_bl.ico");
            this.imageList1.Images.SetKeyName(346, "midi_gr.ico");
            this.imageList1.Images.SetKeyName(347, "midi_mg.ico");
            this.imageList1.Images.SetKeyName(348, "midi_tl.ico");
            this.imageList1.Images.SetKeyName(349, "minesweeper.ico");
            this.imageList1.Images.SetKeyName(350, "mixer_cd_sound.ico");
            this.imageList1.Images.SetKeyName(351, "mixer_keyboard_musical.ico");
            this.imageList1.Images.SetKeyName(352, "mixer_sound.ico");
            this.imageList1.Images.SetKeyName(353, "modem.ico");
            this.imageList1.Images.SetKeyName(354, "monitor_application.ico");
            this.imageList1.Images.SetKeyName(355, "monitor_black.ico");
            this.imageList1.Images.SetKeyName(356, "monitor_blue_grad.ico");
            this.imageList1.Images.SetKeyName(357, "monitor_gear.ico");
            this.imageList1.Images.SetKeyName(358, "monitor_moon.ico");
            this.imageList1.Images.SetKeyName(359, "monitor_tweakui.ico");
            this.imageList1.Images.SetKeyName(360, "monitor_windows.ico");
            this.imageList1.Images.SetKeyName(361, "mouse.ico");
            this.imageList1.Images.SetKeyName(362, "mouse_hide.ico");
            this.imageList1.Images.SetKeyName(363, "mouse_location.ico");
            this.imageList1.Images.SetKeyName(364, "mouse_ms.ico");
            this.imageList1.Images.SetKeyName(365, "mouse_padlock.ico");
            this.imageList1.Images.SetKeyName(366, "mouse_snap.ico");
            this.imageList1.Images.SetKeyName(367, "mouse_speed.ico");
            this.imageList1.Images.SetKeyName(368, "mouse_trails.ico");
            this.imageList1.Images.SetKeyName(369, "mouse_wireless.ico");
            this.imageList1.Images.SetKeyName(370, "move_system_file.ico");
            this.imageList1.Images.SetKeyName(371, "movie_maker.ico");
            this.imageList1.Images.SetKeyName(372, "msagent.ico");
            this.imageList1.Images.SetKeyName(373, "msagent_file.ico");
            this.imageList1.Images.SetKeyName(374, "msconfig.ico");
            this.imageList1.Images.SetKeyName(375, "ms-dos.ico");
            this.imageList1.Images.SetKeyName(376, "ms-dos_2.ico");
            this.imageList1.Images.SetKeyName(377, "msg_error.ico");
            this.imageList1.Images.SetKeyName(378, "msg_information.ico");
            this.imageList1.Images.SetKeyName(379, "msg_question.ico");
            this.imageList1.Images.SetKeyName(380, "msg_warning.ico");
            this.imageList1.Images.SetKeyName(381, "msg_warning_inv.ico");
            this.imageList1.Images.SetKeyName(382, "mshearts.ico");
            this.imageList1.Images.SetKeyName(383, "msie_box.ico");
            this.imageList1.Images.SetKeyName(384, "msie1.ico");
            this.imageList1.Images.SetKeyName(385, "msie2.ico");
            this.imageList1.Images.SetKeyName(386, "msinfo32.ico");
            this.imageList1.Images.SetKeyName(387, "msn.ico");
            this.imageList1.Images.SetKeyName(388, "msn_cool.ico");
            this.imageList1.Images.SetKeyName(389, "msn2.ico");
            this.imageList1.Images.SetKeyName(390, "msn3.ico");
            this.imageList1.Images.SetKeyName(391, "multimedia.ico");
            this.imageList1.Images.SetKeyName(392, "nail.ico");
            this.imageList1.Images.SetKeyName(393, "netmeeting.ico");
            this.imageList1.Images.SetKeyName(394, "netmeeting_share.ico");
            this.imageList1.Images.SetKeyName(395, "netshow.ico");
            this.imageList1.Images.SetKeyName(396, "netshow_arrow.ico");
            this.imageList1.Images.SetKeyName(397, "netshow_notransm.ico");
            this.imageList1.Images.SetKeyName(398, "network.ico");
            this.imageList1.Images.SetKeyName(399, "network_cool_two_pcs.ico");
            this.imageList1.Images.SetKeyName(400, "network_drive.ico");
            this.imageList1.Images.SetKeyName(401, "network_drive_cool.ico");
            this.imageList1.Images.SetKeyName(402, "network_drive_unavailable.ico");
            this.imageList1.Images.SetKeyName(403, "network_drive_unavailable_cool.ico");
            this.imageList1.Images.SetKeyName(404, "network_drive_world.ico");
            this.imageList1.Images.SetKeyName(405, "network_internet_pcs_installer.ico");
            this.imageList1.Images.SetKeyName(406, "network_normal_two_pcs.ico");
            this.imageList1.Images.SetKeyName(407, "network_television.ico");
            this.imageList1.Images.SetKeyName(408, "network_televisons.ico");
            this.imageList1.Images.SetKeyName(409, "network_three_pcs.ico");
            this.imageList1.Images.SetKeyName(410, "newspaper.ico");
            this.imageList1.Images.SetKeyName(411, "newspaper_mail.ico");
            this.imageList1.Images.SetKeyName(412, "no.ico");
            this.imageList1.Images.SetKeyName(413, "no2.ico");
            this.imageList1.Images.SetKeyName(414, "note.ico");
            this.imageList1.Images.SetKeyName(415, "notepad.ico");
            this.imageList1.Images.SetKeyName(416, "notepad_file.ico");
            this.imageList1.Images.SetKeyName(417, "notepad_file_gear.ico");
            this.imageList1.Images.SetKeyName(418, "odbc.ico");
            this.imageList1.Images.SetKeyName(419, "ole.ico");
            this.imageList1.Images.SetKeyName(420, "ole2.ico");
            this.imageList1.Images.SetKeyName(421, "outlook_express.ico");
            this.imageList1.Images.SetKeyName(422, "outlook_express_tack.ico");
            this.imageList1.Images.SetKeyName(423, "outlook_express_tack_drive.ico");
            this.imageList1.Images.SetKeyName(424, "outlook_express_tack_folder.ico");
            this.imageList1.Images.SetKeyName(425, "overlay_black.ico");
            this.imageList1.Images.SetKeyName(426, "overlay_refresh.ico");
            this.imageList1.Images.SetKeyName(427, "overlay_share.ico");
            this.imageList1.Images.SetKeyName(428, "overlay_share_cool.ico");
            this.imageList1.Images.SetKeyName(429, "overlay_shortcut.ico");
            this.imageList1.Images.SetKeyName(430, "package.ico");
            this.imageList1.Images.SetKeyName(431, "paint.ico");
            this.imageList1.Images.SetKeyName(432, "paint_file.ico");
            this.imageList1.Images.SetKeyName(433, "paint_old.ico");
            this.imageList1.Images.SetKeyName(434, "paint_window.ico");
            this.imageList1.Images.SetKeyName(435, "paintbrush.ico");
            this.imageList1.Images.SetKeyName(436, "palm_computer.ico");
            this.imageList1.Images.SetKeyName(437, "paper_roll.ico");
            this.imageList1.Images.SetKeyName(438, "pci_card.ico");
            this.imageList1.Images.SetKeyName(439, "pci_card_alt.ico");
            this.imageList1.Images.SetKeyName(440, "pcx.ico");
            this.imageList1.Images.SetKeyName(441, "pcx_alt.ico");
            this.imageList1.Images.SetKeyName(442, "phone_desk.ico");
            this.imageList1.Images.SetKeyName(443, "pictures.ico");
            this.imageList1.Images.SetKeyName(444, "pie_chart_drvspace.ico");
            this.imageList1.Images.SetKeyName(445, "pifedit.ico");
            this.imageList1.Images.SetKeyName(446, "power_management.ico");
            this.imageList1.Images.SetKeyName(447, "print_server.ico");
            this.imageList1.Images.SetKeyName(448, "printer.ico");
            this.imageList1.Images.SetKeyName(449, "printer_big.ico");
            this.imageList1.Images.SetKeyName(450, "printer_cool.ico");
            this.imageList1.Images.SetKeyName(451, "printer_def.ico");
            this.imageList1.Images.SetKeyName(452, "printer_def_diskette.ico");
            this.imageList1.Images.SetKeyName(453, "printer_def_network.ico");
            this.imageList1.Images.SetKeyName(454, "printer_desk.ico");
            this.imageList1.Images.SetKeyName(455, "printer_diskette.ico");
            this.imageList1.Images.SetKeyName(456, "printer_feeding_slot.ico");
            this.imageList1.Images.SetKeyName(457, "printer_network.ico");
            this.imageList1.Images.SetKeyName(458, "printer_pause.ico");
            this.imageList1.Images.SetKeyName(459, "printer_play.ico");
            this.imageList1.Images.SetKeyName(460, "printer_plotter.ico");
            this.imageList1.Images.SetKeyName(461, "printer_question.ico");
            this.imageList1.Images.SetKeyName(462, "printer_shared.ico");
            this.imageList1.Images.SetKeyName(463, "printer_slim.ico");
            this.imageList1.Images.SetKeyName(464, "printer_slot_filled.ico");
            this.imageList1.Images.SetKeyName(465, "processor.ico");
            this.imageList1.Images.SetKeyName(466, "program_manager.ico");
            this.imageList1.Images.SetKeyName(467, "ram_drive.ico");
            this.imageList1.Images.SetKeyName(468, "recycle_bin_directory.ico");
            this.imageList1.Images.SetKeyName(469, "recycle_bin_empty.ico");
            this.imageList1.Images.SetKeyName(470, "recycle_bin_empty_2k.ico");
            this.imageList1.Images.SetKeyName(471, "recycle_bin_empty_cool.ico");
            this.imageList1.Images.SetKeyName(472, "recycle_bin_file.ico");
            this.imageList1.Images.SetKeyName(473, "recycle_bin_file_directory.ico");
            this.imageList1.Images.SetKeyName(474, "recycle_bin_full.ico");
            this.imageList1.Images.SetKeyName(475, "recycle_bin_full_2k.ico");
            this.imageList1.Images.SetKeyName(476, "recycle_bin_full_cool.ico");
            this.imageList1.Images.SetKeyName(477, "regedit.ico");
            this.imageList1.Images.SetKeyName(478, "regedit_binary.ico");
            this.imageList1.Images.SetKeyName(479, "regedit_binary_lock.ico");
            this.imageList1.Images.SetKeyName(480, "regedit_file.ico");
            this.imageList1.Images.SetKeyName(481, "regedit_string.ico");
            this.imageList1.Images.SetKeyName(482, "registration.ico");
            this.imageList1.Images.SetKeyName(483, "registration_no.ico");
            this.imageList1.Images.SetKeyName(484, "removable_disk_drive.ico");
            this.imageList1.Images.SetKeyName(485, "removable_disk_drive_alt.ico");
            this.imageList1.Images.SetKeyName(486, "rename.ico");
            this.imageList1.Images.SetKeyName(487, "replace_directory.ico");
            this.imageList1.Images.SetKeyName(488, "replace_file.ico");
            this.imageList1.Images.SetKeyName(489, "restrict.ico");
            this.imageList1.Images.SetKeyName(490, "rj_jack.ico");
            this.imageList1.Images.SetKeyName(491, "Roland_GS.ico");
            this.imageList1.Images.SetKeyName(492, "scandisk.ico");
            this.imageList1.Images.SetKeyName(493, "scanner.ico");
            this.imageList1.Images.SetKeyName(494, "scanner_alt.ico");
            this.imageList1.Images.SetKeyName(495, "scanner_alt_network.ico");
            this.imageList1.Images.SetKeyName(496, "scanner_camera.ico");
            this.imageList1.Images.SetKeyName(497, "scanner_video_cam.ico");
            this.imageList1.Images.SetKeyName(498, "scanregw.ico");
            this.imageList1.Images.SetKeyName(499, "sched_tasks.ico");
            this.imageList1.Images.SetKeyName(500, "screen_keyboard.ico");
            this.imageList1.Images.SetKeyName(501, "script_file_blue.ico");
            this.imageList1.Images.SetKeyName(502, "script_file_teal.ico");
            this.imageList1.Images.SetKeyName(503, "script_file_yellow.ico");
            this.imageList1.Images.SetKeyName(504, "scsi.ico");
            this.imageList1.Images.SetKeyName(505, "search_computer.ico");
            this.imageList1.Images.SetKeyName(506, "search_directory.ico");
            this.imageList1.Images.SetKeyName(507, "search_file.ico");
            this.imageList1.Images.SetKeyName(508, "search_file_2.ico");
            this.imageList1.Images.SetKeyName(509, "search_file_2_cool.ico");
            this.imageList1.Images.SetKeyName(510, "search_file_3.ico");
            this.imageList1.Images.SetKeyName(511, "search_laptop_1.ico");
            this.imageList1.Images.SetKeyName(512, "search_laptop_2.ico");
            this.imageList1.Images.SetKeyName(513, "search_laptop_3.ico");
            this.imageList1.Images.SetKeyName(514, "search_laptop_4.ico");
            this.imageList1.Images.SetKeyName(515, "search_server.ico");
            this.imageList1.Images.SetKeyName(516, "search_web.ico");
            this.imageList1.Images.SetKeyName(517, "server_gear.ico");
            this.imageList1.Images.SetKeyName(518, "server_to_desktop.ico");
            this.imageList1.Images.SetKeyName(519, "server_window.ico");
            this.imageList1.Images.SetKeyName(520, "settings_gear.ico");
            this.imageList1.Images.SetKeyName(521, "settings_gear_cool.ico");
            this.imageList1.Images.SetKeyName(522, "shell_window1.ico");
            this.imageList1.Images.SetKeyName(523, "shell_window2.ico");
            this.imageList1.Images.SetKeyName(524, "shell_window3.ico");
            this.imageList1.Images.SetKeyName(525, "shell_window4.ico");
            this.imageList1.Images.SetKeyName(526, "shell_window5.ico");
            this.imageList1.Images.SetKeyName(527, "shell_window6.ico");
            this.imageList1.Images.SetKeyName(528, "shut_down_cool.ico");
            this.imageList1.Images.SetKeyName(529, "shut_down_normal.ico");
            this.imageList1.Images.SetKeyName(530, "shut_down_with_computer.ico");
            this.imageList1.Images.SetKeyName(531, "signature.ico");
            this.imageList1.Images.SetKeyName(532, "signature_excl.ico");
            this.imageList1.Images.SetKeyName(533, "signature_no.ico");
            this.imageList1.Images.SetKeyName(534, "sndvol32_input.ico");
            this.imageList1.Images.SetKeyName(535, "sndvol32_main.ico");
            this.imageList1.Images.SetKeyName(536, "sndvol32_output.ico");
            this.imageList1.Images.SetKeyName(537, "SoundGrn.ico");
            this.imageList1.Images.SetKeyName(538, "SoundPu2.ico");
            this.imageList1.Images.SetKeyName(539, "SoundPur.ico");
            this.imageList1.Images.SetKeyName(540, "SoundTel.ico");
            this.imageList1.Images.SetKeyName(541, "SoundVor.ico");
            this.imageList1.Images.SetKeyName(542, "SoundYel.ico");
            this.imageList1.Images.SetKeyName(543, "spider.ico");
            this.imageList1.Images.SetKeyName(544, "standby_monitor_moon.ico");
            this.imageList1.Images.SetKeyName(545, "standby_monitor_moon_cool.ico");
            this.imageList1.Images.SetKeyName(546, "start_menu_shortcuts.ico");
            this.imageList1.Images.SetKeyName(547, "start_menu_xp.ico");
            this.imageList1.Images.SetKeyName(548, "system_restore.ico");
            this.imageList1.Images.SetKeyName(549, "telephony.ico");
            this.imageList1.Images.SetKeyName(550, "template_directory_net_web.ico");
            this.imageList1.Images.SetKeyName(551, "template_empty.ico");
            this.imageList1.Images.SetKeyName(552, "template_nework_conn.ico");
            this.imageList1.Images.SetKeyName(553, "template_nework_places.ico");
            this.imageList1.Images.SetKeyName(554, "template_printer.ico");
            this.imageList1.Images.SetKeyName(555, "template_scanner_camera.ico");
            this.imageList1.Images.SetKeyName(556, "template_sched_task.ico");
            this.imageList1.Images.SetKeyName(557, "template_world.ico");
            this.imageList1.Images.SetKeyName(558, "themes.ico");
            this.imageList1.Images.SetKeyName(559, "time_and_date.ico");
            this.imageList1.Images.SetKeyName(560, "tip.ico");
            this.imageList1.Images.SetKeyName(561, "tools_gear.ico");
            this.imageList1.Images.SetKeyName(562, "tree.ico");
            this.imageList1.Images.SetKeyName(563, "true_type_paint.ico");
            this.imageList1.Images.SetKeyName(564, "trust0.ico");
            this.imageList1.Images.SetKeyName(565, "trust1_restrict.ico");
            this.imageList1.Images.SetKeyName(566, "tune-up.ico");
            this.imageList1.Images.SetKeyName(567, "unplug_eject_pc.ico");
            this.imageList1.Images.SetKeyName(568, "unplug_storage.ico");
            this.imageList1.Images.SetKeyName(569, "ups.ico");
            this.imageList1.Images.SetKeyName(570, "url1.ico");
            this.imageList1.Images.SetKeyName(571, "url1a.ico");
            this.imageList1.Images.SetKeyName(572, "url2.ico");
            this.imageList1.Images.SetKeyName(573, "usb.ico");
            this.imageList1.Images.SetKeyName(574, "usb_port.ico");
            this.imageList1.Images.SetKeyName(575, "user_calendar.ico");
            this.imageList1.Images.SetKeyName(576, "user_card.ico");
            this.imageList1.Images.SetKeyName(577, "user_card_view.ico");
            this.imageList1.Images.SetKeyName(578, "user_computer.ico");
            this.imageList1.Images.SetKeyName(579, "user_computer_pair.ico");
            this.imageList1.Images.SetKeyName(580, "user_network.ico");
            this.imageList1.Images.SetKeyName(581, "user_world.ico");
            this.imageList1.Images.SetKeyName(582, "users.ico");
            this.imageList1.Images.SetKeyName(583, "users_green.ico");
            this.imageList1.Images.SetKeyName(584, "users_key.ico");
            this.imageList1.Images.SetKeyName(585, "utopia_smiley.ico");
            this.imageList1.Images.SetKeyName(586, "video_.ico");
            this.imageList1.Images.SetKeyName(587, "video_compression.ico");
            this.imageList1.Images.SetKeyName(588, "video_gr.ico");
            this.imageList1.Images.SetKeyName(589, "video_mg.ico");
            this.imageList1.Images.SetKeyName(590, "video_mk.ico");
            this.imageList1.Images.SetKeyName(591, "video_tl.ico");
            this.imageList1.Images.SetKeyName(592, "web_file.ico");
            this.imageList1.Images.SetKeyName(593, "web_file_set.ico");
            this.imageList1.Images.SetKeyName(594, "wia_img_a.ico");
            this.imageList1.Images.SetKeyName(595, "wia_img_check.ico");
            this.imageList1.Images.SetKeyName(596, "wia_img_color.ico");
            this.imageList1.Images.SetKeyName(597, "wia_img_color_sound.ico");
            this.imageList1.Images.SetKeyName(598, "wia_img_gray.ico");
            this.imageList1.Images.SetKeyName(599, "window_red_hilights.ico");
            this.imageList1.Images.SetKeyName(600, "windows.ico");
            this.imageList1.Images.SetKeyName(601, "windows_button.ico");
            this.imageList1.Images.SetKeyName(602, "windows_movie.ico");
            this.imageList1.Images.SetKeyName(603, "windows_slanted.ico");
            this.imageList1.Images.SetKeyName(604, "windows_three.ico");
            this.imageList1.Images.SetKeyName(605, "windows_title.ico");
            this.imageList1.Images.SetKeyName(606, "windows_update_large.ico");
            this.imageList1.Images.SetKeyName(607, "windows_update_old.ico");
            this.imageList1.Images.SetKeyName(608, "windows_update_small.ico");
            this.imageList1.Images.SetKeyName(609, "winhelp_small_icons.png");
            this.imageList1.Images.SetKeyName(610, "WinRep.ico");
            this.imageList1.Images.SetKeyName(611, "winrep_mag_glass.ico");
            this.imageList1.Images.SetKeyName(612, "wm.ico");
            this.imageList1.Images.SetKeyName(613, "wm_file.ico");
            this.imageList1.Images.SetKeyName(614, "world.ico");
            this.imageList1.Images.SetKeyName(615, "world_address_book.ico");
            this.imageList1.Images.SetKeyName(616, "world_lock.ico");
            this.imageList1.Images.SetKeyName(617, "world_network_directories.ico");
            this.imageList1.Images.SetKeyName(618, "world_phonereceiver.ico");
            this.imageList1.Images.SetKeyName(619, "world_star.ico");
            this.imageList1.Images.SetKeyName(620, "write_card_phone.ico");
            this.imageList1.Images.SetKeyName(621, "write_file.ico");
            this.imageList1.Images.SetKeyName(622, "write_red.ico");
            this.imageList1.Images.SetKeyName(623, "write_wordpad.ico");
            this.imageList1.Images.SetKeyName(624, "write_yellow.ico");
            this.imageList1.Images.SetKeyName(625, "xml.ico");
            this.imageList1.Images.SetKeyName(626, "xml_gear.ico");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LemonChiffon;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(73, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(908, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the student information management system";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.spContainer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Management System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.spContainer.Panel1.ResumeLayout(false);
            this.spContainer.Panel2.ResumeLayout(false);
            this.spContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).EndInit();
            this.spContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_PwdModify;
        private System.Windows.Forms.ToolStripMenuItem exitSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem studentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加学员AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importStudentsInBatchesIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentInformationManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.SplitContainer spContainer;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnStuManage;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
    }
}

