using System;

namespace NullObject {

    public class Book : AbstractBook {

        public Book(string title) {
            this.title = title;
        }

        public override string GetTitle() {
            return title;
        }

    }

}
