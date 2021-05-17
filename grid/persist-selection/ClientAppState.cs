using System.Collections.Generic;

namespace persist_selection
{
    public class ClientAppState
    {
        public List<Employee> PersistedSelectedItems { get; set; } = new List<Employee>();
    }
}
