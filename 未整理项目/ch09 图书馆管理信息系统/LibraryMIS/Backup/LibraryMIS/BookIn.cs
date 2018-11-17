using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace LibraryMIS
{
	/// <summary>
	/// BookIn ��ժҪ˵����
	/// </summary>
	public class BookIn : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textPrice;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textBDate;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textType;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textPublish;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textWriter;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBName;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btIn;
		private System.Windows.Forms.TextBox textOutDate;
		private System.Windows.Forms.TextBox textInDate1;
		private System.Windows.Forms.Button btClose;
		private System.Windows.Forms.Label text;
		private System.Windows.Forms.TextBox textDay;
		private System.Windows.Forms.TextBox textMoney;
		private System.Windows.Forms.TextBox textNow;
		private System.Windows.Forms.TextBox textBigDay;
		private System.Windows.Forms.DataGrid dataGrid1;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textPID;
		private OleDbConnection oleConnection1 = null;

		public BookIn()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();
			this.oleConnection1 = new OleDbConnection(LibraryMIS.database.dbConnection.connection);

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btClose = new System.Windows.Forms.Button();
			this.label15 = new System.Windows.Forms.Label();
			this.btIn = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.text = new System.Windows.Forms.Label();
			this.textBigDay = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textNow = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textMoney = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textDay = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textInDate1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textOutDate = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.textPrice = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.textBDate = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.textType = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.textPublish = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textWriter = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBName = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBID = new System.Windows.Forms.TextBox();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.label6 = new System.Windows.Forms.Label();
			this.textPID = new System.Windows.Forms.TextBox();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.textPID);
			this.groupBox2.Controls.Add(this.btClose);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.btIn);
			this.groupBox2.Controls.Add(this.groupBox4);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.textBID);
			this.groupBox2.Controls.Add(this.dataGrid1);
			this.groupBox2.Location = new System.Drawing.Point(8, 16);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(520, 250);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "����";
			// 
			// btClose
			// 
			this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btClose.Location = new System.Drawing.Point(320, 216);
			this.btClose.Name = "btClose";
			this.btClose.TabIndex = 26;
			this.btClose.Text = "ȡ��";
			this.btClose.Click += new System.EventHandler(this.btClose_Click);
			// 
			// label15
			// 
			this.label15.ForeColor = System.Drawing.Color.Red;
			this.label15.Location = new System.Drawing.Point(400, 24);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(56, 16);
			this.label15.TabIndex = 24;
			this.label15.Text = "�밴�س�";
			// 
			// btIn
			// 
			this.btIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btIn.Location = new System.Drawing.Point(112, 216);
			this.btIn.Name = "btIn";
			this.btIn.TabIndex = 23;
			this.btIn.Text = "����";
			this.btIn.Click += new System.EventHandler(this.btIn_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.text);
			this.groupBox4.Controls.Add(this.textBigDay);
			this.groupBox4.Controls.Add(this.label5);
			this.groupBox4.Controls.Add(this.textNow);
			this.groupBox4.Controls.Add(this.label4);
			this.groupBox4.Controls.Add(this.textMoney);
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Controls.Add(this.textDay);
			this.groupBox4.Controls.Add(this.label2);
			this.groupBox4.Controls.Add(this.textInDate1);
			this.groupBox4.Controls.Add(this.label1);
			this.groupBox4.Controls.Add(this.textOutDate);
			this.groupBox4.Controls.Add(this.label13);
			this.groupBox4.Controls.Add(this.textPrice);
			this.groupBox4.Controls.Add(this.label12);
			this.groupBox4.Controls.Add(this.textBDate);
			this.groupBox4.Controls.Add(this.label11);
			this.groupBox4.Controls.Add(this.textType);
			this.groupBox4.Controls.Add(this.label10);
			this.groupBox4.Controls.Add(this.textPublish);
			this.groupBox4.Controls.Add(this.label9);
			this.groupBox4.Controls.Add(this.textWriter);
			this.groupBox4.Controls.Add(this.label8);
			this.groupBox4.Controls.Add(this.textBName);
			this.groupBox4.Location = new System.Drawing.Point(8, 48);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(504, 152);
			this.groupBox4.TabIndex = 13;
			this.groupBox4.TabStop = false;
			// 
			// text
			// 
			this.text.Location = new System.Drawing.Point(16, 120);
			this.text.Name = "text";
			this.text.Size = new System.Drawing.Size(56, 16);
			this.text.TabIndex = 34;
			this.text.Text = "�涨����";
			// 
			// textBigDay
			// 
			this.textBigDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBigDay.Location = new System.Drawing.Point(72, 120);
			this.textBigDay.Name = "textBigDay";
			this.textBigDay.ReadOnly = true;
			this.textBigDay.TabIndex = 35;
			this.textBigDay.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(336, 88);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 16);
			this.label5.TabIndex = 32;
			this.label5.Text = "��������";
			// 
			// textNow
			// 
			this.textNow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textNow.Location = new System.Drawing.Point(392, 88);
			this.textNow.Name = "textNow";
			this.textNow.ReadOnly = true;
			this.textNow.TabIndex = 33;
			this.textNow.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(336, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 16);
			this.label4.TabIndex = 30;
			this.label4.Text = "������";
			// 
			// textMoney
			// 
			this.textMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textMoney.Location = new System.Drawing.Point(392, 120);
			this.textMoney.Name = "textMoney";
			this.textMoney.ReadOnly = true;
			this.textMoney.TabIndex = 31;
			this.textMoney.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(176, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 16);
			this.label3.TabIndex = 28;
			this.label3.Text = "��������";
			// 
			// textDay
			// 
			this.textDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textDay.Location = new System.Drawing.Point(232, 120);
			this.textDay.Name = "textDay";
			this.textDay.ReadOnly = true;
			this.textDay.TabIndex = 29;
			this.textDay.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(176, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 16);
			this.label2.TabIndex = 26;
			this.label2.Text = "Ӧ������";
			// 
			// textInDate1
			// 
			this.textInDate1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textInDate1.Location = new System.Drawing.Point(232, 88);
			this.textInDate1.Name = "textInDate1";
			this.textInDate1.ReadOnly = true;
			this.textInDate1.TabIndex = 27;
			this.textInDate1.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 16);
			this.label1.TabIndex = 24;
			this.label1.Text = "�������";
			// 
			// textOutDate
			// 
			this.textOutDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textOutDate.Location = new System.Drawing.Point(72, 88);
			this.textOutDate.Name = "textOutDate";
			this.textOutDate.ReadOnly = true;
			this.textOutDate.TabIndex = 25;
			this.textOutDate.Text = "";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(352, 56);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(32, 16);
			this.label13.TabIndex = 22;
			this.label13.Text = "�۸�";
			// 
			// textPrice
			// 
			this.textPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textPrice.Location = new System.Drawing.Point(392, 56);
			this.textPrice.Name = "textPrice";
			this.textPrice.ReadOnly = true;
			this.textPrice.TabIndex = 23;
			this.textPrice.Text = "";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(176, 56);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(56, 16);
			this.label12.TabIndex = 20;
			this.label12.Text = "��������";
			// 
			// textBDate
			// 
			this.textBDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBDate.Location = new System.Drawing.Point(232, 56);
			this.textBDate.Name = "textBDate";
			this.textBDate.ReadOnly = true;
			this.textBDate.TabIndex = 21;
			this.textBDate.Text = "";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(352, 24);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(32, 16);
			this.label11.TabIndex = 18;
			this.label11.Text = "����";
			// 
			// textType
			// 
			this.textType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textType.Location = new System.Drawing.Point(392, 24);
			this.textType.Name = "textType";
			this.textType.ReadOnly = true;
			this.textType.TabIndex = 19;
			this.textType.Text = "";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(16, 56);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(56, 16);
			this.label10.TabIndex = 16;
			this.label10.Text = "������";
			// 
			// textPublish
			// 
			this.textPublish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textPublish.Location = new System.Drawing.Point(72, 56);
			this.textPublish.Name = "textPublish";
			this.textPublish.ReadOnly = true;
			this.textPublish.TabIndex = 17;
			this.textPublish.Text = "";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(192, 24);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(32, 16);
			this.label9.TabIndex = 14;
			this.label9.Text = "����";
			// 
			// textWriter
			// 
			this.textWriter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textWriter.Location = new System.Drawing.Point(232, 24);
			this.textWriter.Name = "textWriter";
			this.textWriter.ReadOnly = true;
			this.textWriter.TabIndex = 15;
			this.textWriter.Text = "";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(16, 24);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(48, 16);
			this.label8.TabIndex = 12;
			this.label8.Text = "ͼ����";
			// 
			// textBName
			// 
			this.textBName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBName.Location = new System.Drawing.Point(72, 24);
			this.textBName.Name = "textBName";
			this.textBName.ReadOnly = true;
			this.textBName.TabIndex = 13;
			this.textBName.Text = "";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(208, 24);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 16);
			this.label7.TabIndex = 12;
			this.label7.Text = "ͼ����";
			// 
			// textBID
			// 
			this.textBID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBID.Location = new System.Drawing.Point(264, 24);
			this.textBID.Name = "textBID";
			this.textBID.Size = new System.Drawing.Size(120, 21);
			this.textBID.TabIndex = 12;
			this.textBID.Text = "";
			this.textBID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBID_KeyDown);
			// 
			// dataGrid1
			// 
			this.dataGrid1.AllowSorting = false;
			this.dataGrid1.AlternatingBackColor = System.Drawing.Color.LightGray;
			this.dataGrid1.BackColor = System.Drawing.Color.DarkGray;
			this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dataGrid1.CaptionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGrid1.CaptionFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGrid1.CaptionForeColor = System.Drawing.Color.Navy;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.ForeColor = System.Drawing.Color.Black;
			this.dataGrid1.GridLineColor = System.Drawing.Color.Black;
			this.dataGrid1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
			this.dataGrid1.HeaderBackColor = System.Drawing.Color.Silver;
			this.dataGrid1.HeaderForeColor = System.Drawing.Color.Black;
			this.dataGrid1.LinkColor = System.Drawing.Color.Navy;
			this.dataGrid1.Location = new System.Drawing.Point(456, 8);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.White;
			this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.Black;
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.SelectionBackColor = System.Drawing.Color.Navy;
			this.dataGrid1.SelectionForeColor = System.Drawing.Color.White;
			this.dataGrid1.Size = new System.Drawing.Size(40, 24);
			this.dataGrid1.TabIndex = 25;
			this.dataGrid1.Visible = false;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 24);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 16);
			this.label6.TabIndex = 28;
			this.label6.Text = "ͼ��֤��";
			// 
			// textPID
			// 
			this.textPID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textPID.Location = new System.Drawing.Point(72, 24);
			this.textPID.Name = "textPID";
			this.textPID.Size = new System.Drawing.Size(120, 21);
			this.textPID.TabIndex = 27;
			this.textPID.Text = "";
			// 
			// BookIn
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.Snow;
			this.ClientSize = new System.Drawing.Size(536, 276);
			this.Controls.Add(this.groupBox2);
			this.Name = "BookIn";
			this.Text = "����";
			this.groupBox2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		DataSet ds;
		private void textBID_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyData.ToString()=="Enter")
			{
				oleConnection1.Open();
				string sql = "select BName as ͼ����,BWriter as ����,BPublish as ������,BDate as ��������,BPrice as �۸�,type as ����,"+
					"ODate as �������,(select longTime from identityinfo where identity=(select identity from person where PID='"+textPID.Text.Trim()+"'))"+
					" as �����ʱ��,dateAdd('m',�����ʱ��,ODate) as Ӧ������,DateDiff('d',Ӧ������,Now) as �������� from book,bookOut where "+
					"book.BID='"+textBID.Text.Trim()+"' and PID='"+textPID.Text.Trim()+"'";
				OleDbDataAdapter adp = new OleDbDataAdapter(sql,oleConnection1);
				ds = new DataSet();
				ds.Clear();
				adp.Fill(ds,"book");
				dataGrid1.DataSource = ds.Tables["book"].DefaultView;
				if (ds.Tables[0].Rows.Count!=0)
				{
					textBName.Text = ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString().Trim();
					textWriter.Text = ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][1].ToString().Trim();
					textPublish.Text = ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][2].ToString().Trim();
					textBDate.Text = ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][3].ToString().Trim();
					textPrice.Text = ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][4].ToString().Trim();
					textType.Text = ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][5].ToString().Trim();
					textOutDate.Text = ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][6].ToString().Trim();
					textBigDay.Text = Convert.ToString(Convert.ToInt16(ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][7].ToString().Trim())*30);
					textInDate1.Text = ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][8].ToString().Trim();
					if (Convert.ToInt16(ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][9].ToString().Trim())>0)
					{
						textDay.Text = ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][9].ToString().Trim();
						textMoney.Text = Convert.ToString(Convert.ToInt16(textDay.Text)*0.15);
					}
					else
					{
						textDay.Text="0";
						textMoney.Text="0";
					}
					textNow.Text = DateTime.Now.ToString();
					dataGrid1.CaptionText = "����"+ds.Tables["book"].Rows.Count+"����¼";
				}
				else
					MessageBox.Show("�ö���û�н��ͼ��","��ʾ");
				sql = "update person set PMoney=PMoney+'"+textMoney.Text+"' where PID='"+textPID.Text.Trim()+"'";
				OleDbCommand cmd = new OleDbCommand(sql,oleConnection1);
				cmd.ExecuteNonQuery();
				oleConnection1.Close();
			}
		}

		private void btIn_Click(object sender, System.EventArgs e)
		{
			if (textBID.Text.Trim()==null)
				MessageBox.Show("����дͼ����","��ʾ");
			else
			{
				oleConnection1.Open();
				string sql = "delete * from bookOut where BID = '"+textBID.Text.Trim()+"',and PID='"+textPID.Text.Trim()+"'";
				OleDbCommand cmd = new OleDbCommand(sql,oleConnection1);
				cmd.ExecuteNonQuery();
				MessageBox.Show("����ɹ�","��ʾ");
			}
		}

		private void btClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
