namespace BuilderDemo
{
    internal class WheelDirector
    {
        private IWheelBuilder _wheelBuilder;

        public WheelDirector(IWheelBuilder wheelBuilder)
        {
            _wheelBuilder = wheelBuilder;
        }

        public Wheel BuildWideWheel()
        {
            try
            {
                _wheelBuilder.Reset();


                _wheelBuilder.BuildWideRim();
                _wheelBuilder.BuildWideTyre();



                _wheelBuilder.BuildBolt();

                _wheelBuilder.BuildBolt();

                _wheelBuilder.BuildBolt();

                _wheelBuilder.BuildBolt();

                _wheelBuilder.Validate();

                return _wheelBuilder.Wheel;
            }
            catch (Exception ex)
            {
                throw new BuildWideWheelException(ex);
            }
        }

        public Wheel BuildSlimWheel()
        {
            try
            {
                _wheelBuilder.Reset();
                _wheelBuilder.BuildSlimRim();
                _wheelBuilder.BuildSlimTyre();



                _wheelBuilder.BuildBolt();

                _wheelBuilder.BuildBolt();

                _wheelBuilder.BuildBolt();

                _wheelBuilder.BuildBolt();

                _wheelBuilder.Validate();

                return _wheelBuilder.Wheel;
            } catch (Exception ex)
            {
                throw new BuildSlimWheelException(ex);
            }
        }
    }
}
