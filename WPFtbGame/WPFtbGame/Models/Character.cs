using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFtbGame.Models
{
    public class Character
    {
        #region ENUMERABLES

        public enum TypeOfDog
        {
            Doxin,
            Bermise,
            Pitbull
        }
        #endregion

        #region FIELDS

        protected int _id;
        protected string _dogName;
        protected int _locationId;
        protected int _age;
        protected TypeOfDog _typeofDog;

        #endregion

        #region PROPERTIES

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string DogName
        {
            get { return _dogName; }
            set { _dogName = value; }
        }

        public int LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public TypeOfDog typeOfDog
        {
            get { return _typeofDog; }
            set { _typeofDog = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Character()
        {

        }

        public Character(string Dogname, TypeOfDog typeOfDog, int locationId)
        {
            _dogName = Dogname;
            _typeofDog = typeOfDog;
            _locationId = locationId;
        }

        #endregion

        #region METHODS

        public virtual string DefaultGreeting()
        {
            return $"Hello, my name is {_Dogname} and I am a {_typeofDog}.";
        }

        #endregion
    }
}
