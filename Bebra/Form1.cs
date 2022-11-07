namespace Bebra
{
    public partial class Form1 : Form
    {
        public enum Table { Game = 0, Company, Genre, Launcher, Showground }
        private Table curTable;

        public Form1()
        {
            InitializeComponent();
            DataGridViewDbLoad();
        }

        private void DataGridViewDbLoad()
        {
            curTable = Table.Game;
            using (GamesModelContext db = new GamesModelContext())
            {
                //Отображаем текущее состояние бд 
                gameDataGridView.DataSource = db.Games.ToList<Game>();
                companyDataGridView.DataSource = db.Companies.ToList<Company>();
                genreDataGridView.DataSource = db.Genres.ToList<Genre>();
                launcherDataGridView.DataSource = db.Launchers.ToList<Launcher>();
                showgroundDataGridView.DataSource = db.Showgrounds.ToList<Showground>();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                using (GamesModelContext db = new GamesModelContext())
                    AddNewObject(db, Tb1.Text, Tb2.Text, Tb3.Text);
            }
            catch {
                //Отображаем сообщение об ошибке
                MessageBox.Show("Данные введены некоректно");
                return;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //Попытка привести к нужному типу
                int id = int.Parse(idTb.Text);

                using (GamesModelContext db = new GamesModelContext())
                {
                    UpdateObject(db, id, Tb1.Text, Tb2.Text, Tb3.Text);
                }
            }
            catch 
            {
                //Отображаем сообщение об ошибке
                MessageBox.Show("Данные введены некоректно");
                return;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(idTb.Text);

                using (GamesModelContext db = new GamesModelContext())
                {
                    DeleteObject(db, id);
                }
            }
            catch {
                //Отображаем сообщение об ошибке
                MessageBox.Show("Данные введены некоректно");
                return;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            curTable = (Table)tabControl1.SelectedIndex;

            label1.Enabled = label2.Enabled = label3.Enabled = label4.Enabled = true;
            Tb1.Enabled = Tb2.Enabled = Tb3.Enabled = true;
            Tb1.Text = Tb2.Text = Tb3.Text = "";

            switch (curTable) 
            {
                case Table.Game:
                    label2.Text = "Название:";
                    label3.Text = "Владелец:";
                    label4.Text = "Цена:";
                    break;
                case Table.Company:
                    label2.Text = "Название:";
                    label3.Text = "Страна:";
                    label4.Text = String.Empty;
                    Tb3.Enabled = false;
                    break;
                case Table.Genre:
                    label2.Text = "Название:";
                    label3.Text = "Описание:";
                    label4.Text = String.Empty;
                    Tb3.Enabled = false;
                    break;
                case Table.Launcher:
                    label2.Text = "Название:";
                    label3.Text = "Компания:";
                    label4.Text = "Версия:";
                    break;
                case Table.Showground:
                    label2.Text = "Название:";
                    label3.Text = "Владелец:";
                    label4.Text = "Описание";
                    break;
            }
        }

        private void UpdateObject(GamesModelContext db, int id, string tb1, string tb2, string tb3) 
        {
            try
            {
                switch (curTable)
                {
                    case Table.Game:
                        int cost = int.Parse(tb3);

                        Game gameToUpdate = new Game { Id = id ,Name = tb1, Owner = tb2, Cost = cost };

                        db.Games.Update(gameToUpdate);
                        db.SaveChanges();

                        gameDataGridView.DataSource = db.Games.ToList<Game>();
                        break;
                    case Table.Company:
                        Company companyToUpdate = new Company { Id = id, Name = tb1, Owner = tb2 };

                        db.Companies.Update(companyToUpdate);
                        db.SaveChanges();

                        companyDataGridView.DataSource = db.Companies.ToList<Company>();
                        break;
                    case Table.Genre:
                        Genre genreToUpdate = new Genre { Id = id, Name = tb1, Description = tb2 };

                        db.Genres.Update(genreToUpdate);
                        db.SaveChanges();

                        genreDataGridView.DataSource = db.Genres.ToList<Genre>();
                        break;
                    case Table.Launcher:
                        Launcher launcherToUpdate = new Launcher { Id = id, Name = tb1, Company = tb2, Version = tb3};

                        db.Launchers.Update(launcherToUpdate);
                        db.SaveChanges();

                        launcherDataGridView.DataSource = db.Launchers.ToList<Launcher>();
                        break;
                    case Table.Showground:
                        Showground showgroundToUpdate = new Showground { Id = id, Name = tb1, Owner = tb2, Description = tb3 };

                        db.Showgrounds.Update(showgroundToUpdate);
                        db.SaveChanges();

                        showgroundDataGridView.DataSource = db.Showgrounds.ToList<Showground>();
                        break;
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Некорректно введены данные");
            }
            catch
            {
                MessageBox.Show("Невозможно обновить данные, которых еще нет в БД");
            }
        }

        private void AddNewObject(GamesModelContext db, string tb1, string tb2, string tb3) 
        {
            switch (curTable)
            {
                case Table.Game:
                    int cost = int.Parse(tb3);

                    db.Games.Add(new Game { Name = tb1, Owner = tb2, Cost = cost });
                    db.SaveChanges();

                    gameDataGridView.DataSource = db.Games.ToList<Game>();
                    break;
                case Table.Company:
                    db.Companies.Add(new Company { Name = tb1, Owner = tb2 });
                    db.SaveChanges();

                    companyDataGridView.DataSource = db.Companies.ToList<Company>();
                    break;
                case Table.Genre:
                    db.Genres.Add(new Genre { Name = tb1, Description = tb2 });
                    db.SaveChanges();

                    genreDataGridView.DataSource = db.Genres.ToList<Genre>();
                    break;
                case Table.Launcher:
                    db.Launchers.Add(new Launcher { Name = tb1, Company = tb2, Version = tb3 });
                    db.SaveChanges();

                    launcherDataGridView.DataSource = db.Launchers.ToList<Launcher>();
                    break;
                case Table.Showground:
                    db.Showgrounds.Add(new Showground { Name = tb1, Owner = tb2, Description = tb3 });
                    db.SaveChanges();

                    showgroundDataGridView.DataSource = db.Showgrounds.ToList<Showground>();
                    break;
            }
        }

        private void DeleteObject(GamesModelContext db, int id)
        {
            switch (curTable)
            {
                case Table.Game:
                    Game? gameToRemove = db.Games.FirstOrDefault<Game?>(game => game.Id == id);
                    if (gameToRemove != null)
                    {
                        db.Games.Remove(gameToRemove);
                        db.SaveChanges();

                        gameDataGridView.DataSource = db.Games.ToList<Game>();
                    }
                    else
                        MessageBox.Show("Нельзя удалить данные, которых нет в БД");
                    break;
                case Table.Company:
                    Company? companyToRemove = db.Companies.FirstOrDefault<Company?>(company => company.Id == id);
                    if (companyToRemove != null)
                    {
                        db.Companies.Remove(companyToRemove);
                        db.SaveChanges();

                        companyDataGridView.DataSource = db.Companies.ToList<Company>();
                    }
                    else
                        MessageBox.Show("Нельзя удалить данные, которых нет в БД");
                    break;
                case Table.Launcher:
                    Launcher? launcherToRemove = db.Launchers.FirstOrDefault<Launcher?>(launcher => launcher.Id == id);
                    if (launcherToRemove != null)
                    {
                        db.Launchers.Remove(launcherToRemove);
                        db.SaveChanges();

                        launcherDataGridView.DataSource = db.Launchers.ToList<Launcher>();
                    }
                    else
                        MessageBox.Show("Нельзя удалить данные, которых нет в БД");
                    break;

                case Table.Genre:
                    Genre? genreToRemove = db.Genres.FirstOrDefault<Genre?>(genre => genre.Id == id);
                    if (genreToRemove != null)
                    {
                        db.Genres.Remove(genreToRemove);
                        db.SaveChanges();

                        genreDataGridView.DataSource = db.Genres.ToList<Genre>();
                    }
                    else
                        MessageBox.Show("Нельзя удалить данные, которых нет в БД");
                    break;

                case Table.Showground:
                    Showground? showgroundToRemove = db.Showgrounds.FirstOrDefault<Showground?>(showground => showground.Id == id);
                    if (showgroundToRemove != null)
                    {
                        db.Showgrounds.Remove(showgroundToRemove);
                        db.SaveChanges();

                        showgroundDataGridView.DataSource = db.Showgrounds.ToList<Showground>();
                    }
                    else
                        MessageBox.Show("Нельзя удалить данные, которых нет в БД");
                    break;
            }
        }
    }
}