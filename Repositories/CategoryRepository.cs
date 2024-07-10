using AppMauiGallery.Models;
using AppMauiGallery.Views.Cells;
using AppMauiGallery.Views.Components.Forms;
using AppMauiGallery.Views.Components.Mains;
using AppMauiGallery.Views.Components.Visuais;
using AppMauiGallery.Views.Layouts;

namespace AppMauiGallery.Repositories;

public class CategoryRepository
{
    public CategoryRepository() { }

    public List<Category> GetCategories()
    {
        List<Category> categories = new List<Category>();
        categories.Add(new Category
        {
            Name = "Layout",
            Components = new List<Component>
            {
                new Component { Title = "StackLayout", Description = "Organização sequencial dos elementos.", Page = typeof(StackLayoutPage) },
                new Component { Title = "Grid", Description = "Organização os elementos dentro de uma tabela.", Page = typeof(GridLayoutPage) },
                new Component { Title = "AbsoluteLayout", Description = "Liberdade total para posicionar e dimensionar elementos na tela.", Page = typeof(AbsoluteLayoutPage) },
                new Component { Title = "FlexLayout", Description = "Organiza os elementos de forma sequencial com muitas opções de personalização.", Page = typeof(FlexLayoutPage) },
            }
        });
        categories.Add(new Category()
        {
            Name = "Componentes (Views)",
            Components = new List<Component> 
            {
                new Component { Title = "BoxView", Description = "Elemento que cria uma caixa para ser apresentada", Page = typeof(BoxViewPage) },
                new Component { Title = "Label", Description = "Apresenta um texto na tela", Page = typeof(LabelPage) },
                new Component { Title = "Button", Description = "Apresenta um botão na tela", Page = typeof(ButtonPage) },
                new Component { Title = "Image", Description = "Apresenta uma imagem na tela", Page = typeof(ImagePage) },
                new Component { Title = "ImageButton", Description = "Apresenta uma imagem com comportamento de botão", Page = typeof(ImageButtonPage) }
            }
        });
        categories.Add(new Category()
        {
            Name = "Visuais",
            Components = new List<Component>
            {
                new Component { Title = "Frame", Description = "Caixa que envolve outros elementos.", Page = typeof(FramePage) },
                new Component { Title = "Border", Description = "Caixa que envolve outros elementos.", Page = typeof(BorderPage) },
                new Component { Title = "Shadow", Description = "Adiciona sombra ao elemento.", Page = typeof(ShadowPage) }
            }
        });
        categories.Add(new Category()
        {
            Name = "Formulários",
            Components = new List<Component>
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
            }
        });
        categories.Add(new Category()
        {
            Name = "Celulas",
            Components = new List<Component>
            {
                new Component { Title = "TextCell", Description = "Apresenta até duas labels onde uma é destinada ao título e outra a descrição", Page = typeof(TextCellPage) },
                new Component { Title = "ImageCell", Description = "Apresenta uma imagem e as duas labels do TextCell", Page = typeof(ImageCellPage) },
                new Component { Title = "SwitchCell", Description = "Apresenta um switch e uma label", Page = typeof(SwitchCellPage) },
                new Component { Title = "EntryCell", Description = "Apresenta um entry e uma label", Page = typeof(EntryCellPage) },
                new Component { Title = "ViewCell", Description = "Permite criar celula com layout personalizado", Page = typeof(ViewCellPage) },
            }
        });

        return categories;
    }
}
