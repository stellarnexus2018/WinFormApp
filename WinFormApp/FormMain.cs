using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp
{
	public partial class FormMain : Form
	{
		/// <summary>
		/// Дефолтный конструктор
		/// </summary>
		public FormMain()
		{
			InitializeComponent();










		}//(FormMain)

		/// <summary>
		/// Загрузка формы
		/// </summary>
		private void FormMain_Load(object sender, EventArgs e)
		{
			//DateTime dtm = DateTime.Now;
			//string time_now = dtm.ToString();
			//tb_one.Text = time_now;
		}//(FormMain_Load)

		/// <summary>
		/// Жмём на кнопарь
		/// </summary>
		private void btn_press_one_Click(object sender, EventArgs e)
		{
			if(tmr_form.Enabled)
			{
				tmr_form.Enabled = false;
			} else
			{
				tmr_form.Enabled = true;
			}

			//DateTime dtm = DateTime.Now;
			//string time_now = dtm.ToString();
			//tb_one.Text = time_now;
		}//(btn_press_one_Click)

		/// <summary>
		/// Тикаем таймером
		/// </summary>
		private void tmr_form_Tick(object sender, EventArgs e)
		{
			DateTime dtm = DateTime.Now;
			string time_now = dtm.ToString();
			tb_one.Text = time_now;
		}//(tmr_form_Tick)
	}
}