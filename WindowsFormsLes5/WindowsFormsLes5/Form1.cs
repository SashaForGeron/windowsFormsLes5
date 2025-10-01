using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLes5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Movie
        {
            public string Title;
            public string Genre;
            public override string ToString() => $"{Title} ({Genre})";
        }
        List<Movie> movies = new List<Movie>();
        void RefreshMovies()
        {
            lbMovies.Items.Clear();
            string filter = cmbGenreFilter.SelectedItem?.ToString() ?? "All";
            foreach (var m in movies)
            {
                if (filter != "All" && !string.Equals(m.Genre, filter, StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }
                lbMovies.Items.Add(m);
            }
        }
        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            if (txtTitle != null && txtGenre != null)
            {
                Movie m = new Movie { Title = txtTitle.Text.Trim(), Genre = txtGenre.Text.Trim() };
                movies.Add(m);
                RefreshMovies();
            }
        }

        private void btnFilterMovies_Click(object sender, EventArgs e)
        {
            RefreshMovies();
        }

        class Contact
        {
            public string Name; public string Phone; public override string ToString() => $"{Name} - {Phone}";
        }
        void RefreshContact()
        {
            lbContacts.Items.Clear();
            foreach (var c in contacts) lbContacts.Items.Add(c);
        }
        List<Contact> contacts = new List<Contact>();
        private void btnAddContact_Click(object sender, EventArgs e)
        {
            if (Name != null)
            {
                contacts.Add(new Contact { Name = txtName.Text.Trim(), Phone = txtPhone.Text.Trim() });
                RefreshContact();
            }
        }

        private void btnFindContact_Click(object sender, EventArgs e)
        {
            string q = txtSearch.Text.Trim().ToLower();
            lbContacts.Items.Clear();
            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].Name.ToLower().Contains(q))
                    lbContacts.Items.Add(contacts[i]);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            RefreshContact();
        }

        List<string> shopping = new List<string>();

        void RefreshItems()
        {
            lbItems.Items.Clear();
            foreach (var it in shopping) lbItems.Items.Add(it);
        }
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            shopping.Add(txtItem.Text.Trim());
            RefreshItems();
        }

        private void btnMarkDone_Click(object sender, EventArgs e)
        {
            int idx = lbItems.SelectedIndex;
            if (idx >= 0 && !shopping[idx].StartsWith("[✔] "))
            {
                shopping[idx] = "[✔] " + shopping[idx];
            }
            RefreshItems();
        }

        private void btnClearDone_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < shopping.Count)
            {
                if (shopping[i].StartsWith("[✔] "))
                    shopping.RemoveAt(i);
                else i++;
            }
            RefreshItems();
        }
        List<string> playlist = new List<string>();
        int currentIndex = -1;
        Random rand = new Random();

        void RefreshPlaylist()
        {
            lbPlaylist.Items.Clear();
            foreach (var s in playlist) lbPlaylist.Items.Add(s);
            if (currentIndex >= 0 && currentIndex < playlist.Count)
            {
                lbPlaylist.SelectedIndex = currentIndex;
            }
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            playlist.Add(txtSong.Text.Trim());
            RefreshPlaylist();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (playlist.Count == 0) return;
            currentIndex = (currentIndex + 1) % playlist.Count;
            lbPlaylist.SelectedIndex = currentIndex;
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            for (int i = playlist.Count - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                var tmp = playlist[i];
                playlist[i] = playlist[j];
                playlist[j] = tmp;
            }
            currentIndex = -1;
            RefreshPlaylist();
        }
        class Book { public string Title; public string Author; public override string ToString() => $"{Title} - {Author}"; }
        List<Book> books = new List<Book>();
        void RefreshBooks()
        {
            lbBooks.Items.Clear();
            foreach (var book in books) lbBooks.Items.Add(book);
        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            books.Add(new Book { Title = txtTitleBook.Text.Trim(), Author = txtAuthor.Text.Trim() });
            RefreshBooks();
        }

        private void btnSortBooks_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < books.Count - 1; i++)
            {
                for(int j = 0; j < books.Count - 1 - i; j++)
                {
                    if (string.Compare(books[j].Title, books[j + 1].Title, StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        var tmp = books[j];
                        books[j] = books[j + 1];
                        books[j + 1] = tmp;
                    }
                }
            }
            RefreshBooks();
        }

        class GuestEntry { public string Name; public string Message; public DateTime Date; public override string ToString() => $"{Name} - {Message} ({Date:G})"; }
        List<GuestEntry> guestBook = new List<GuestEntry>();
        void RefreshGuestBook()
        {
            lbGuestBook.Items.Clear();
            foreach (var g in guestBook) lbGuestBook.Items.Add(g);
        }
        private void btnAddEntry_Click(object sender, EventArgs e)
        {
            GuestEntry guest = new GuestEntry { Name = txtGuestName.Text.Trim(), Message = txtMessage.Text.Trim(), Date = DateTime.Now};
            guestBook.Add(guest);
            RefreshGuestBook();
        }

        private void btnShowToday_Click(object sender, EventArgs e)
        {
            lbGuestBook.Items.Clear();
            foreach(var g in guestBook)
            {
                if(g.Date.Date == DateTime.Now.Date)
                    lbGuestBook.Items.Add(g);
            }
        }

        private void btnShowAllGuest_Click(object sender, EventArgs e)
        {
            RefreshGuestBook() ;
        }
    }
}
