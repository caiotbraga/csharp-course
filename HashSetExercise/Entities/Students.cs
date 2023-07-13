using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetExercise.Entities {
    internal class Students {
        public Students(int id) {
            this.id = id;
        }

        public int id { get; set; }

        public override int GetHashCode() {
            return id.GetHashCode();
        }

        public override bool Equals(object? obj) {
            if(!(obj is Students)) {
                return false;
            }
            Students other = obj as Students; 
            return id.Equals(other.id);
        }
    }
}
