using System;
using System.Collections.Generic;
using System.Text;
using NabazRemote.Controllers.ViewInterfaces;
using NabazRemote.Domain;



namespace NabazRemote.Controllers
{
    public class NabaztagController
    {
        public NabaztagController()
        {
            views = new List<NabaztagView>();
        }

        public NabaztagRepository Repository
        {
            get
            {
                if (repository == null)
                {
                    throw new Exception("not initialised");
                }
                return repository;
            }
            set
            {
                repository = value;
            }
        }

        public void AttachView(NabaztagView view)
        {
            views.Add(view);
            view.AttachController(this);
        }

        public void AddNabaztag(Nabaztag nabaztag)
        {
            repository.Add(nabaztag);
            RefreshViews();
        }


        public IList<Nabaztag> ListNabaztag()
        {
            return repository.GetAll();
        }

        private void RefreshViews()
        {
            foreach (NabaztagView view in views)
            {
                view.Refresh();
            }
        }

        private IList<NabaztagView> views;
        private NabaztagRepository repository;

    }
}
