using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WpfTest2012.Game;
using WpfTest2012.HelperClasses;
using WpfTest2012.Models;

namespace WpfTest2012.Pages.UserPages
{
    /// <summary>
    /// Логика взаимодействия для PageCreateDeck.xaml
    /// </summary>
    public partial class PageCreateDeck : Page
    {
        private readonly DeckCreation _deckCreation;

        public PageCreateDeck(Deck deck)
        {
            InitializeComponent();
            _deckCreation = new DeckCreation(deck);

            var cards = DataBaseConnectContext.ConnectContext.Card.ToArray();
            var cardNames = new List<string>();
            foreach (var card in cards)
                cardNames.Add(card.Name);

            CardCmbBox.ItemsSource = cardNames;
            CardCmbBox.SelectedIndex = 0;
        }

        private void CmbBoxCardChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            RnCardName.Text = box.SelectedItem.ToString();
            RnCardDescription.Text = _deckCreation.FindCard(box.SelectedItem.ToString()).Description;
        }

        private void BtnAddCard(object sender, System.Windows.RoutedEventArgs e)
        {
            _deckCreation.AddCard(CardCmbBox.SelectedItem.ToString());
            RnCardCount.Text = _deckCreation.GetCards().Count().ToString();
        }

        private void BtnSaveDeck(object sender, System.Windows.RoutedEventArgs e)
        {
            if(_deckCreation.GetCards().Count() < 10)
            {
                MessageBox.Show("Need MORE cards");
                return;
            }

            if (_deckCreation.Save())
            {
                FrameNav.frameNavigation.GoBack();
                FrameNav.frameNavigation.GoBack();
                MessageBox.Show("Save completed");
            }
            else
            {
                MessageBox.Show("Save uncompleted");
            }
        }

        private void BtnDeleteCard(object sender, RoutedEventArgs e)
        {
            _deckCreation.RemoveCard(CardCmbBox.SelectedItem.ToString());
            RnCardCount.Text = _deckCreation.GetCards().Count().ToString();
        }
    }
}
