using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SimpleFileShredder
{
    public class UserController
    {
        FileController fileController;

        public UserController(FileController fileController)
        {
            this.fileController = fileController;
        }
    }
}
