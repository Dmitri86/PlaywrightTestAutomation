using System.Threading.Tasks;

namespace Core.Controls.Interfaces
{
    public interface ITextBox
    {
        public Task SetText(string text);
    }
}