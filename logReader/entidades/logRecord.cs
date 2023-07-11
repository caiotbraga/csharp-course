using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logReader.entidades {
    internal class logRecord {
        public String Username { get; set; }
        private DateTime moment;

        public logRecord(string name, DateTime dateTime) {
            this.Username = name;
            this.moment = dateTime;
        }

        public override int GetHashCode() {
            return Username.GetHashCode();
        }

        public override bool Equals(object? obj) {
            if(!(obj is logRecord)) {
                return false;
            }
            logRecord other = obj as logRecord;
            return Username.Equals(other.Username);
        }
    }
}
