using AppMauiGallery.Models;
using AppMauiGallery.Views.Accessability;
using AppMauiGallery.Views.Animations;
using AppMauiGallery.Views.Cells;
using AppMauiGallery.Views.CommunityMaui;
using AppMauiGallery.Views.Components.Forms;
using AppMauiGallery.Views.Components.Mains;
using AppMauiGallery.Views.Components.Visuais;
using AppMauiGallery.Views.Layouts;
using AppMauiGallery.Views.Lists;
using AppMauiGallery.Views.Shells;
using AppMauiGallery.Views.Styles;
using AppMauiGallery.Views.Utils;

namespace AppMauiGallery.Repositories;

public partial class GroupComponentRepository : IGroupComponentRepository
{
    private void LoadData()
    {
        _components = new List<Component>();
        _groupComponents = new List<GroupComponent>();

        LoadLayouts();
        LoadControls();
        LoadVisuals();
        LoadForms();
        LoadCells();
        LoadCollections();
        LoadStyles();
        LoadAnimations();
        LoadUtils();
        LoadShell();
        LoadAccessability();
        LoadCommunityMaui();
    }

    private void LoadCommunityMaui()
    {
        var components = new List<Component>
            {
                new Component { Title = "Sanckbar e Toast", Description = "Formas de emitir mensagens para o usuário", Page = typeof(AlertPage) },
                new Component { Title = "Behaviors", Description = "Apresenta alguns behaviors que são: Masked, StatusBar, EventToCommand(MVVM)", Page = typeof(CommunityBehaviorPage) },
                new Component { Title = "Expander", Description = "Um componente que oculta/apresenta um conteúdo associado a ele", Page = typeof(ExpanderPage) },
                new Component { Title = "Popup", Description = "Apresenta um modal(pop-up) na tela", Page = typeof(PopupPage) },
                new Component { Title = "MediaElement", Description = "Player de mídia (áudio/vídeo)", Page = typeof(MidiaElementPage) },
            };

        var group = new GroupComponent() { Name = ".NET MAUI Community Toolkit" };
        group.AddRange(components);

        _components.AddRange(components);
        _groupComponents.Add(group);
    }

    private void LoadShell()
    {
        var components = new List<Component>
            {
                new Component { Title = "Shell", Description = "Uma nova forma de estruturar as páginas do nosso projeto.", Page = typeof(AppShell), IsReplaceMainPage = true },
            };

        var group = new GroupComponent() { Name = "Shell" };
        group.AddRange(components);

        _components.AddRange(components);
        _groupComponents.Add(group);
    }

    private void LoadAccessability()
    {
        var components = new List<Component>
            {
                new Component { Title = "Semantic", Description = "Elemento que torna nosso aplicativo visível para quem tem necessidades especiais.", Page = typeof(AccessabilityPage) },
            };

        var group = new GroupComponent() { Name = "Accessability" };
        group.AddRange(components);

        _components.AddRange(components);
        _groupComponents.Add(group);
    }

    private void LoadLayouts()
    {
        var components = new List<Component>
            {
                new Component { Title = "StackLayout", Description = "Organização sequencial dos elementos.", Page = typeof(StackLayoutPage) },
                new Component { Title = "Grid", Description = "Organização os elementos dentro de uma tabela.", Page = typeof(GridLayoutPage) },
                new Component { Title = "AbsoluteLayout", Description = "Liberdade total para posicionar e dimensionar elementos na tela.", Page = typeof(AbsoluteLayoutPage) },
                new Component { Title = "FlexLayout", Description = "Organiza os elementos de forma sequencial com muitas opções de personalização.", Page = typeof(FlexLayoutPage) },
            };

        var group = new GroupComponent() { Name = "Layout" };
        group.AddRange(components);

        _components.AddRange(components);
        _groupComponents.Add(group);
    }

    private void LoadControls()
    {
        var components = new List<Component>
            {
                new Component { Title = "BoxView", Description = "Elemento que cria uma caixa para ser apresentada", Page = typeof(BoxViewPage) },
                new Component { Title = "Label", Description = "Apresenta um texto na tela", Page = typeof(LabelPage) },
                new Component { Title = "Button", Description = "Apresenta um botão na tela", Page = typeof(ButtonPage) },
                new Component { Title = "Image", Description = "Apresenta uma imagem na tela", Page = typeof(ImagePage) },
                new Component { Title = "ImageButton", Description = "Apresenta uma imagem com comportamento de botão", Page = typeof(ImageButtonPage) }
            };

        var group = new GroupComponent() { Name = "Controles (Views)" };
        group.AddRange(components);

        _components.AddRange(components);
        _groupComponents.Add(group);
    }

    private void LoadVisuals()
    {
        var components = new List<Component>
            {
                new Component { Title = "Frame", Description = "Caixa que envolve outros elementos.", Page = typeof(FramePage) },
                new Component { Title = "Border", Description = "Caixa que envolve outros elementos.", Page = typeof(BorderPage) },
                new Component { Title = "Shadow", Description = "Adiciona sombra ao elemento.", Page = typeof(ShadowPage) }
            };

        var group = new GroupComponent() { Name = "Visuals" };
        group.AddRange(components);

        _components.AddRange(components);
        _groupComponents.Add(group);
    }

    private void LoadForms()
    {
        var components = new List<Component>
            {
                new Component { Title = "Entry", Description = "Cria caixa de entrada de texto.", Page = typeof(EntryPage) },
                new Component { Title = "Editor", Description = "Cria caixa de entrada de texto de multiplas linhas.", Page = typeof(EditorPage) },
                new Component { Title = "Checkbox", Description = "Cria caixa de marcação.", Page = typeof(CheckboxPage) },
                new Component { Title = "RadioButton", Description = "Cria caixa de marcação de escolha unica.", Page = typeof(RadioButtonPage) },
                new Component { Title = "Switch", Description = "Caixa de marcação booleana.", Page = typeof(SwitchPage) },
                new Component { Title = "Stepper", Description = "Cria opções de incrementar ou decrementar um número.", Page = typeof(StepperPage) },
                new Component { Title = "Slider", Description = "Cria barra que incrementar ou decrementar um número.", Page = typeof(SliderPage) },
                new Component { Title = "TimerPicker", Description = "Seleção da hora e do minuto.", Page = typeof(TimePickerPage) },
                new Component { Title = "DatePicker", Description = "Seleção da data.", Page = typeof(DatePickerPage) },
                new Component { Title = "SearchBar", Description = "Caixa de busca.", Page = typeof(SearchBarPage) },
                new Component { Title = "Picker", Description = "Pegar itens de uma lista.", Page = typeof(PickerPage) }
            };

        var group = new GroupComponent() { Name = "Formulários" };
        group.AddRange(components);

        _components.AddRange(components);
        _groupComponents.Add(group);
    }

    private void LoadCells()
    {
        var components = new List<Component>
            {
                new Component { Title = "TextCell", Description = "Apresenta até duas labels onde uma é destinada ao título e outra a descrição", Page = typeof(TextCellPage) },
                new Component { Title = "ImageCell", Description = "Apresenta uma imagem e as duas labels do TextCell", Page = typeof(ImageCellPage) },
                new Component { Title = "SwitchCell", Description = "Apresenta um switch e uma label", Page = typeof(SwitchCellPage) },
                new Component { Title = "EntryCell", Description = "Apresenta um entry e uma label", Page = typeof(EntryCellPage) },
                new Component { Title = "ViewCell", Description = "Permite criar celula com layout personalizado", Page = typeof(ViewCellPage) },
            };

        var group = new GroupComponent() { Name = "Células" };
        group.AddRange(components);

        _components.AddRange(components);
        _groupComponents.Add(group);
    }

    private void LoadCollections()
    {
        var components = new List<Component>
            {
                new Component { Title = "TableView", Description = "Apresenta células em linhas separadas e permite agrupar por seção", Page = typeof(TableViewPage) },
                new Component { Title = "Picker", Description = "Apresenta uma lista de seleção única", Page = typeof(PickerListPage) },
                new Component { Title = "ListView", Description = "Apresenta uma lista de itens", Page = typeof(ListViewPage) },
                new Component { Title = "CollectionView", Description = "Apresenta uma lista de itens", Page = typeof(CollectionViewPage) },
                new Component { Title = "CarouselView", Description = "Apresenta uma lista de itens horinzontais com navegação lateral", Page = typeof(CarouselViewPage) },
                new Component { Title = "BindableLyout (Atributo)", Description = "Permite que layouts possam apresentar listas e coleções", Page = typeof(BindableLayoutPage) },
                new Component { Title = "DataTemplateSelector (Classe)", Description = "Permite que itens possam ser apresentados com layouts diferentes", Page = typeof(DataTemplateSelectorPage) },
            };

        var group = new GroupComponent() { Name = "Coleções" };
        group.AddRange(components);

        _components.AddRange(components);
        _groupComponents.Add(group);
    }

    private void LoadStyles()
    {
        var components = new List<Component>
            {
                new Component { Title = "Implicit & Explicit Styles", Description = "Explicar como funciona os estilos.", Page = typeof(ImplicitExplicitStyles) },
                new Component { Title = "Global Styles", Description = "Como criar estilos para todo o projeto.", Page = typeof(GlobalStyle) },
                new Component { Title = "ApplyToDerivedTypes", Description = "Aplicar um estilo aos elementos derivados do classe/componente atual.", Page = typeof(ApplyDerivedTypes) },
                new Component { Title = "Inheritance Style", Description = "Como criar estilos derivados de outros.", Page = typeof(InheritanceStyle) },
                new Component { Title = "Style Class", Description = "Cria classes de estilos para serem aplicadas em componentes.", Page = typeof(StyleClassPage) },
                new Component { Title = "Static Resource /Dynamic Resource", Description = "Define se o estilo pode ser alterado em tempo real.", Page = typeof(StaticDynamicResource) },
                new Component { Title = "Tema", Description = "Define um tema padrão para o projeto.", Page = typeof(Theme) },
                new Component { Title = "AppThemeBinding", Description = "Adapta o tema ao modo claro ou escuro do Sistema operacional.", Page = typeof(AppThemeBindingPage) },
                new Component { Title = "Visual State Manager (VSM)", Description = "Personalizar a apresentação de acordo com o estado do componente.", Page = typeof(VisualStateManagerPage) },
            };

        var group = new GroupComponent() { Name = "Styles" };
        group.AddRange(components);

        _components.AddRange(components);
        _groupComponents.Add(group);
    }

    private void LoadAnimations()
    {
        var components = new List<Component>
            {
                new Component { Title = "Basic Animation", Description = "Animação básica do .NET MAUI.", Page = typeof(BasicAnimation) },                
            };

        var group = new GroupComponent() { Name = "Animation" };
        group.AddRange(components);

        _components.AddRange(components);
        _groupComponents.Add(group);
    }

    private void LoadUtils()
    {
        var components = new List<Component>
            {
                new Component { Title = "Behavior", Description = "Lógica que pode ser associada a um componente da tela.", Page = typeof(BehaviorPage) },
                new Component { Title = "Trigger", Description = "Gatilho que dispara uma alteração visual no componente.", Page = typeof(TriggerPage) },
                new Component { Title = "OnPlatform/OnIdiom", Description = "Define valores diferentes entre o S.O. e também pelo tipo de dispositivo.", Page = typeof(PlatformIdiomPage) },
                new Component { Title = "Fontes", Description = "Como usar fontes diferentes no nosso projeto.", Page = typeof(FontPage) },
                new Component { Title = "Color/Brush", Description = "Como colocar as cores no nosso projeto.", Page = typeof(ColorPage) },
            };

        var group = new GroupComponent() { Name = "Utils" };
        group.AddRange(components);

        _components.AddRange(components);
        _groupComponents.Add(group);
    }
}
