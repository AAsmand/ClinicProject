using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClinicProject.Model;
using ClinicProject.Data.Repositories;

namespace ClinicProject
{
    public partial class AddDoctor : Form
    {
        int ClinicId;
        IPeopleRepository peopleRepository;
        ITurnTypeRepository turnTypeRepository;
        IDoctorRepository doctorRepository;
        ITurnTypeDoctorRepository turnTypeDoctorRepository;
        List<TurnType> list = new List<TurnType>();
        int peopleId;
        public AddDoctor(int clinicId)
        {
            InitializeComponent();
            ClinicId = clinicId;
            peopleRepository = new PeopleRepository();
            turnTypeRepository = new TurnTypeRepository();
            doctorRepository = new DoctorRepository();
            turnTypeDoctorRepository = new TurnTypeDoctorRepository();
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            People p = peopleRepository.GetPeopleByCode(CodeMelliTxt.Text);
            if (p == null)
            {
                if (MessageBox.Show("فرد مورد نظر در دیتابیس وجود ندارد\n مایل به افزودن آن هستید ؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    AddPeople addPeople = new AddPeople(ClinicId);
                    addPeople.Show();
                }
            }
            else
            {
                NameLbl.Text = "";
                NameLbl.Text += p.Name + " " + p.Family;
                CodeMelliLbl.Text = p.CodeMelli;
                peopleId = p.Id;
            }
        }

        private void AddDoctor_Load(object sender, EventArgs e)
        {
            initItemGrid();
            initGrid();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CodeMelliTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddTypeBtn_Click(object sender, EventArgs e)
        {

            TurnType type = turnTypeRepository.GetTurnType(int.Parse(TurnTypeGrid.Rows[int.Parse(TurnTypeGrid.CurrentCell.RowIndex.ToString())].Cells[0].Value.ToString()));
            if (type != null)
            {
                TurnType found = list.Find(t => t.Id == type.Id);
                if (found != null)
                {
                    MessageBox.Show("این خدمت از پیش انتخاب شده است !", "خطا", MessageBoxButtons.OK);
                }
                else
                {
                    list.Add(type);
                    initItemGrid();
                }
            }
        }
        public void initItemGrid()
        {
            SelectedTypeGrid.AutoGenerateColumns = false;
            SelectedTypeGrid.DataSource = null;
            SelectedTypeGrid.DataSource = list;
        }
        public void initGrid()
        {
            TurnTypeGrid.AutoGenerateColumns = false;
            TurnTypeGrid.DataSource = turnTypeRepository.getTurnTypes(ClinicId);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor()
            {
                PeopleId = peopleId,
                ClinicId = this.ClinicId,
            };
            doctorRepository.AddDoctor(doctor);
            foreach (var item in list)
            {
                TurnTypeDoctor turnTypeDoctor = new TurnTypeDoctor()
                {
                    DoctorId=doctor.Id,
                    TurnTypeId=item.Id
                };
                turnTypeDoctorRepository.AddTurnTypeDoctor(turnTypeDoctor);
            }
            var result = MessageBox.Show("عملیات با موفقیت انجام شد", "موفق", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
