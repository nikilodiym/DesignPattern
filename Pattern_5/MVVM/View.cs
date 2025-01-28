using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_5.MVVM
{
    public class View
    {
        public ViewModel ViewModel { get; set; } = null!;

        public void UpdateView(string data)
        {
            ViewModel.Data = data;
            Console.WriteLine($"View is displaying: {data}");
        }
    }
}
