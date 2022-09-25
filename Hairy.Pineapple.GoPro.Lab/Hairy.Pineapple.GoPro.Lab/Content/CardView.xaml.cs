namespace Hairy.Pineapple.GoPro.Lab.Content;

public partial class CardView : ContentView
{
    public static readonly BindableProperty CardTitleProperty = BindableProperty.Create(nameof(CardTitle), typeof(string), typeof(CardView), string.Empty);

    public static readonly BindableProperty CardDescriptionProperty = BindableProperty.Create(nameof(CardDescription), typeof(string), typeof(CardView), string.Empty);

    public static readonly BindableProperty CardBorderColourProperty = BindableProperty.Create(nameof(BorderColour), typeof(Color), typeof(CardView), string.Empty);
    
    public static readonly BindableProperty IconBackgroundColourProperty = BindableProperty.Create(nameof(IconBackgroundColour), typeof(Color), typeof(CardView), string.Empty);
    
    public static readonly BindableProperty IconImageSourceProperty = BindableProperty.Create(nameof(IconImageSource), typeof(string), typeof(CardView), string.Empty);

    public string CardTitle
    {
        get => (string)GetValue(CardView.CardTitleProperty);
        set => SetValue(CardView.CardTitleProperty, value);
    }

    public Color BorderColour
    {
        get => (Color)GetValue(CardView.CardBorderColourProperty);
        set => SetValue(CardView.CardBorderColourProperty, value);
    }

    public string CardDescription
    {
        get => (string)GetValue(CardView.CardDescriptionProperty);
        set => SetValue(CardView.CardDescriptionProperty, value);
    }

    public Color IconBackgroundColour
    {
        get => (Color)GetValue(CardView.IconBackgroundColourProperty);
        set => SetValue(CardView.IconBackgroundColourProperty, value);
    }

    public string IconImageSource
    {
        get => (string)GetValue(CardView.IconImageSourceProperty);
        set => SetValue(CardView.IconImageSourceProperty, value);
    }

    public CardView()
    {
        InitializeComponent();
    }
}