namespace _4m03ZgadnijLiczbe
{
    public partial class MainPage : ContentPage
    {
        int wylosowana = 0;
        int liczbaProb = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnStartClicked(object sender, EventArgs e)
        {
            liczbaProb = 0;
            Random r = new Random();
            wylosowana = r.Next(0, 101);
            btnZatwierdz.IsEnabled = true;
            entLiczba.IsEnabled = true;
        }


        private void btnZatwierdzClicked(object sender, EventArgs e)
        {
            string s = entLiczba.Text;
            entLiczba.Text = "";
            int liczba;
            if(int.TryParse(s, out liczba))
            {
                liczbaProb++;
                lblProby.Text = $"Liczba prób: {liczbaProb}";
                if(liczba == wylosowana)
                {
                    lblWynik.Text = "BRAWO - to jest ta liczba!";
                    btnZatwierdz.IsEnabled = false;
                    entLiczba.IsEnabled = false;
                }
                else if(liczba > wylosowana)
                {
                    lblWynik.Text = "za dużo";
                }
                else
                    lblWynik.Text = "za mało";
            }
            else               
                return;
        }
    }

}
