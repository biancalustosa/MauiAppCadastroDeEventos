﻿
namespace MauiAppCadastroDeEventos;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new MauiAppCadastroDeEventos.Views.CadastrarEvento());
	}

    protected override Window CreateWindow(IActivationState? activationState)
    {
		var window = base.CreateWindow(activationState);

		window.Width = 400;
		window.Height = 600;

        return window;
    }
}
