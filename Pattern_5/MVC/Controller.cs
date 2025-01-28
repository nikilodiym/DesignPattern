using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_5.MVC
{
    public class Controller
    {
        private readonly Model _model;
        private readonly View _view;

        public Controller(Model model, View view)
        {
            _model = model;
            _view = view;
        }

        public void UpdateModel(string data)
        {
            _model.Data = data;
            _view.Display(_model.Data);
        }
    }
}
