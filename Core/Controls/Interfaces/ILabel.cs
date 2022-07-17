using System.Threading.Tasks;

namespace Core.Controls.Interfaces
{
    public interface ILabel
    {
        public Task<string> GetText();
    }
}