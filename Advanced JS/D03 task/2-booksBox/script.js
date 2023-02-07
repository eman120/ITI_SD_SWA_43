var books = function(title, numofChapters, author, numofPages, publisher,numofCopies)
{
    var self = this;

    Object.defineProperties(self , {
        title: {
            value: title || null
        },
        numofChapters : {
            value: numofChapters || null
        },
        author :{
            value: author || null
        },
        numofPages :{
            value: numofPages || null
        },
        numofChapters :{
            value: numofChapters || null
        },
        numofCopies :{
            value: numofCopies || 1
        },
    })
}


var box = function(height, width, length, material, content)
{
    var self = this;

    Object.defineProperties(self , {
        height: {
            value: height || null
        },
        width : {
            value: width || null
        },
        length :{
            value: length || null
        },
        material :{
            value: material || null
        },
        content :{
            value: []
        },

        countBooks : {
            value : 0, 
            writable:true
        },

        addBook : {
            value : function(title, numberChapters, author, numberPages, publisher, numberCopies){
                var index = self.content.findIndex((book) => book.title === title);

                if (index === -1)
                    self.content.push(new books(title, numberChapters, author, numberPages, publisher, numberCopies));
                else
                    self.content[index].numberCopies = self.content[index].numberCopies + numberCopies;

                //box.count += numberCopies;
                self.countBooks += numberCopies;
            }
        },

        deleteBook: {
            value: function (title) {
                var index = self.content.findIndex((book) => book.title = title);

                if (index === -1) throw new Error('No book with the given title');
                else {
                    if (self.content[index].numberCopies === 1)
                        self.content = self.content.splice(index, 1);
                    else
                        self.content[index].numberCopies--;
                }

                //box.count -= 1;
                self.countBooks -= 1;
            }
        },

        getCount : {
            value : function(){
                //return content.length;
                return self.countBooks;
            }
        },

        valueOf : {
            value : function(){
                //return content.length;
                return self.countBooks;
            }
        },
        toString : {
            value: function(){
                var s = "The box's description is:\n\tHeight = " +  self.height + "\n\tWidth = " + self.width + "\n\tLength = " + self.length + "\n\tMaterial = " + self.material + "\nStatus of saved books:\n\t";
                for (var i = 0; i < self.content.length; i++) {
                    s += self.content[i].title + ' = ' + self.content[i].numofCopies + " copies";
                    if (i !== self.content.length - 1) s += ', ';
                }
        
                return s + '.';
            }
        }
    })
}



var bx = new box(10, 5, 1, 'wood');

bx.addBook('b1', 10, 'aa', 123, 'aa', 5);
bx.addBook('b1', 10, 'aa', 123, 'aa', 5);
bx.addBook('b2', 10, 'aa', 123, 'aa', 5);
console.log('Total ' + bx.getCount());
console.log(bx.toString());


var bx2 = new box(20, 15, 1, 'plastic');

bx2.addBook('b3', 10, 'aa', 123, 'aa', 5);
bx2.addBook('b4', 10, 'aa', 123, 'aa', 2);
bx2.addBook('b5', 10, 'aa', 123, 'aa', 1);
console.log('Total ' + bx2.getCount());
console.log(bx2.toString());

console.log('b1+b2 = ' + (bx + bx2));


/*box = many books 
count of books inside box
delete any books (book title)*/
