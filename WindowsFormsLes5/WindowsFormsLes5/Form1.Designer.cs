namespace WindowsFormsLes5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.cmbGenreFilter = new System.Windows.Forms.ComboBox();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnFilterMovies = new System.Windows.Forms.Button();
            this.lbMovies = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.lbContacts = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnFindContact = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.btnMarkDone = new System.Windows.Forms.Button();
            this.btnClearDone = new System.Windows.Forms.Button();
            this.txtSong = new System.Windows.Forms.TextBox();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.lbPlaylist = new System.Windows.Forms.ListBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.txtTitleBook = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.btnSortBooks = new System.Windows.Forms.Button();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnAddEntry = new System.Windows.Forms.Button();
            this.lbGuestBook = new System.Windows.Forms.ListBox();
            this.btnShowToday = new System.Windows.Forms.Button();
            this.btnShowAllGuest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(13, 13);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 22);
            this.txtTitle.TabIndex = 0;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(13, 42);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(100, 22);
            this.txtGenre.TabIndex = 1;
            // 
            // cmbGenreFilter
            // 
            this.cmbGenreFilter.FormattingEnabled = true;
            this.cmbGenreFilter.Location = new System.Drawing.Point(210, 11);
            this.cmbGenreFilter.Name = "cmbGenreFilter";
            this.cmbGenreFilter.Size = new System.Drawing.Size(121, 24);
            this.cmbGenreFilter.TabIndex = 2;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(119, 12);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(85, 52);
            this.btnAddMovie.TabIndex = 3;
            this.btnAddMovie.Text = "Добавить фильм";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnFilterMovies
            // 
            this.btnFilterMovies.Location = new System.Drawing.Point(337, 11);
            this.btnFilterMovies.Name = "btnFilterMovies";
            this.btnFilterMovies.Size = new System.Drawing.Size(91, 53);
            this.btnFilterMovies.TabIndex = 4;
            this.btnFilterMovies.Text = "Применить фильтр";
            this.btnFilterMovies.UseVisualStyleBackColor = true;
            this.btnFilterMovies.Click += new System.EventHandler(this.btnFilterMovies_Click);
            // 
            // lbMovies
            // 
            this.lbMovies.FormattingEnabled = true;
            this.lbMovies.ItemHeight = 16;
            this.lbMovies.Location = new System.Drawing.Point(434, 11);
            this.lbMovies.Name = "lbMovies";
            this.lbMovies.Size = new System.Drawing.Size(120, 84);
            this.lbMovies.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(13, 137);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(13, 166);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 22);
            this.txtPhone.TabIndex = 7;
            // 
            // btnAddContact
            // 
            this.btnAddContact.Location = new System.Drawing.Point(13, 195);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(100, 43);
            this.btnAddContact.TabIndex = 8;
            this.btnAddContact.Text = "Добавить контакт";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // lbContacts
            // 
            this.lbContacts.FormattingEnabled = true;
            this.lbContacts.ItemHeight = 16;
            this.lbContacts.Location = new System.Drawing.Point(119, 137);
            this.lbContacts.Name = "lbContacts";
            this.lbContacts.Size = new System.Drawing.Size(120, 116);
            this.lbContacts.TabIndex = 9;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(246, 137);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 22);
            this.txtSearch.TabIndex = 10;
            // 
            // btnFindContact
            // 
            this.btnFindContact.Location = new System.Drawing.Point(246, 164);
            this.btnFindContact.Name = "btnFindContact";
            this.btnFindContact.Size = new System.Drawing.Size(85, 43);
            this.btnFindContact.TabIndex = 11;
            this.btnFindContact.Text = "Найти контакт";
            this.btnFindContact.UseVisualStyleBackColor = true;
            this.btnFindContact.Click += new System.EventHandler(this.btnFindContact_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(245, 213);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(85, 43);
            this.btnShowAll.TabIndex = 12;
            this.btnShowAll.Text = "Показать все";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(13, 279);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(100, 22);
            this.txtItem.TabIndex = 13;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(13, 308);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(84, 40);
            this.btnAddItem.TabIndex = 14;
            this.btnAddItem.Text = "Добавить предмет";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lbItems
            // 
            this.lbItems.FormattingEnabled = true;
            this.lbItems.ItemHeight = 16;
            this.lbItems.Location = new System.Drawing.Point(119, 279);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(120, 100);
            this.lbItems.TabIndex = 15;
            // 
            // btnMarkDone
            // 
            this.btnMarkDone.Location = new System.Drawing.Point(246, 279);
            this.btnMarkDone.Name = "btnMarkDone";
            this.btnMarkDone.Size = new System.Drawing.Size(113, 51);
            this.btnMarkDone.TabIndex = 16;
            this.btnMarkDone.Text = "Пометить как выполненный";
            this.btnMarkDone.UseVisualStyleBackColor = true;
            this.btnMarkDone.Click += new System.EventHandler(this.btnMarkDone_Click);
            // 
            // btnClearDone
            // 
            this.btnClearDone.Location = new System.Drawing.Point(245, 339);
            this.btnClearDone.Name = "btnClearDone";
            this.btnClearDone.Size = new System.Drawing.Size(114, 42);
            this.btnClearDone.TabIndex = 17;
            this.btnClearDone.Text = "Удалить все выполненные";
            this.btnClearDone.UseVisualStyleBackColor = true;
            this.btnClearDone.Click += new System.EventHandler(this.btnClearDone_Click);
            // 
            // txtSong
            // 
            this.txtSong.Location = new System.Drawing.Point(434, 137);
            this.txtSong.Name = "txtSong";
            this.txtSong.Size = new System.Drawing.Size(100, 22);
            this.txtSong.TabIndex = 18;
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(434, 164);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(100, 43);
            this.btnAddSong.TabIndex = 19;
            this.btnAddSong.Text = "Добавить песню";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // lbPlaylist
            // 
            this.lbPlaylist.FormattingEnabled = true;
            this.lbPlaylist.ItemHeight = 16;
            this.lbPlaylist.Location = new System.Drawing.Point(540, 134);
            this.lbPlaylist.Name = "lbPlaylist";
            this.lbPlaylist.Size = new System.Drawing.Size(120, 84);
            this.lbPlaylist.TabIndex = 20;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(666, 134);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(95, 23);
            this.btnNext.TabIndex = 21;
            this.btnNext.Text = "Следующая";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Location = new System.Drawing.Point(667, 164);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(102, 24);
            this.btnShuffle.TabIndex = 22;
            this.btnShuffle.Text = "Перемешать";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // txtTitleBook
            // 
            this.txtTitleBook.Location = new System.Drawing.Point(434, 279);
            this.txtTitleBook.Name = "txtTitleBook";
            this.txtTitleBook.Size = new System.Drawing.Size(100, 22);
            this.txtTitleBook.TabIndex = 23;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(434, 308);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 22);
            this.txtAuthor.TabIndex = 24;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(434, 339);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(100, 40);
            this.btnAddBook.TabIndex = 25;
            this.btnAddBook.Text = "Добавить книгу";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.ItemHeight = 16;
            this.lbBooks.Location = new System.Drawing.Point(541, 297);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(120, 84);
            this.lbBooks.TabIndex = 26;
            // 
            // btnSortBooks
            // 
            this.btnSortBooks.Location = new System.Drawing.Point(667, 308);
            this.btnSortBooks.Name = "btnSortBooks";
            this.btnSortBooks.Size = new System.Drawing.Size(121, 40);
            this.btnSortBooks.TabIndex = 27;
            this.btnSortBooks.Text = "Отсортировать книги";
            this.btnSortBooks.UseVisualStyleBackColor = true;
            this.btnSortBooks.Click += new System.EventHandler(this.btnSortBooks_Click);
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(246, 387);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(100, 22);
            this.txtGuestName.TabIndex = 28;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(246, 416);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(100, 22);
            this.txtMessage.TabIndex = 29;
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.Location = new System.Drawing.Point(246, 445);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(100, 42);
            this.btnAddEntry.TabIndex = 30;
            this.btnAddEntry.Text = "Добавить посетителя";
            this.btnAddEntry.UseVisualStyleBackColor = true;
            this.btnAddEntry.Click += new System.EventHandler(this.btnAddEntry_Click);
            // 
            // lbGuestBook
            // 
            this.lbGuestBook.FormattingEnabled = true;
            this.lbGuestBook.ItemHeight = 16;
            this.lbGuestBook.Location = new System.Drawing.Point(352, 387);
            this.lbGuestBook.Name = "lbGuestBook";
            this.lbGuestBook.Size = new System.Drawing.Size(120, 132);
            this.lbGuestBook.TabIndex = 31;
            // 
            // btnShowToday
            // 
            this.btnShowToday.Location = new System.Drawing.Point(479, 385);
            this.btnShowToday.Name = "btnShowToday";
            this.btnShowToday.Size = new System.Drawing.Size(106, 61);
            this.btnShowToday.TabIndex = 32;
            this.btnShowToday.Text = "Показать сегодняшних посетителей";
            this.btnShowToday.UseVisualStyleBackColor = true;
            this.btnShowToday.Click += new System.EventHandler(this.btnShowToday_Click);
            // 
            // btnShowAllGuest
            // 
            this.btnShowAllGuest.Location = new System.Drawing.Point(478, 452);
            this.btnShowAllGuest.Name = "btnShowAllGuest";
            this.btnShowAllGuest.Size = new System.Drawing.Size(107, 61);
            this.btnShowAllGuest.TabIndex = 33;
            this.btnShowAllGuest.Text = "Показать всех посетителей";
            this.btnShowAllGuest.UseVisualStyleBackColor = true;
            this.btnShowAllGuest.Click += new System.EventHandler(this.btnShowAllGuest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 571);
            this.Controls.Add(this.btnShowAllGuest);
            this.Controls.Add(this.btnShowToday);
            this.Controls.Add(this.lbGuestBook);
            this.Controls.Add(this.btnAddEntry);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.btnSortBooks);
            this.Controls.Add(this.lbBooks);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitleBook);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lbPlaylist);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.txtSong);
            this.Controls.Add(this.btnClearDone);
            this.Controls.Add(this.btnMarkDone);
            this.Controls.Add(this.lbItems);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnFindContact);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lbContacts);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbMovies);
            this.Controls.Add(this.btnFilterMovies);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.cmbGenreFilter);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.ComboBox cmbGenreFilter;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnFilterMovies;
        private System.Windows.Forms.ListBox lbMovies;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.ListBox lbContacts;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnFindContact;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.Button btnMarkDone;
        private System.Windows.Forms.Button btnClearDone;
        private System.Windows.Forms.TextBox txtSong;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.ListBox lbPlaylist;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.TextBox txtTitleBook;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.Button btnSortBooks;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnAddEntry;
        private System.Windows.Forms.ListBox lbGuestBook;
        private System.Windows.Forms.Button btnShowToday;
        private System.Windows.Forms.Button btnShowAllGuest;
    }
}

