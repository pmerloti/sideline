using sideline.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sideline.viewmodels
{
    public class OrganizationVM: ObservableObject
    {
        private List<Organization> organizations;

        public OrganizationVM(ref List<Organization> organizations)
        {
            this.organizations = organizations;
            Squads = GetCurrentSquads();
        }

        public ReadOnlyObservableCollection<Tuple<string, TeamSquad>> Squads;
        public TeamSquad HomeSquad;

        public ReadOnlyObservableCollection<Tuple<string,TeamSquad>> GetCurrentSquads()
        {
            List<TeamSquad> allSquads = organizations.SelectMany(o => o.Squads).ToList();

            var tupleList = new ObservableCollection<Tuple<string, TeamSquad>>();
            foreach (var squad in allSquads)
            {
                tupleList.Add(new Tuple<string, TeamSquad>(squad.Name, squad));
            }

            return new ReadOnlyObservableCollection<Tuple<string, TeamSquad>>(tupleList);
        }
    }
}
