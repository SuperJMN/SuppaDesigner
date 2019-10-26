using ReactiveUI;

namespace Designer.Domain.ViewModels
{
    public abstract class Graphic : ReactiveObject
    {
        private double left;
        private double top;
        private double width;
        private double height;
        private double angle;

        public double Left
        {
            get => left;
            set => this.RaiseAndSetIfChanged(ref left, value);
        }

        public double Top
        {
            get => top;
            set => this.RaiseAndSetIfChanged(ref top, value);
        }

        public double Width
        {
            get => width;
            set => this.RaiseAndSetIfChanged(ref width, value);
        }

        public double Height
        {
            get => height;
            set => this.RaiseAndSetIfChanged(ref height, value);
        }

        public double Angle
        {
            get => angle;
            set => this.RaiseAndSetIfChanged(ref angle, value);
        }
    }
}