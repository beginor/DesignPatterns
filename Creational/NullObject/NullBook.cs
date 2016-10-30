using System;

namespace NullObject {

    class NullBook : AbstractBook {

        public override string GetTitle() {
            return "Not avaible in Customer Database";
        }

    }

}