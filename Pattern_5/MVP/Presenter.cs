using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_5.MVP
{
    public class Presenter
    {
        private readonly Model _model;
        private readonly IView _view;

        public Presenter(Model model, IView view)
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
