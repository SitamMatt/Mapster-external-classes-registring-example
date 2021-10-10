using mappers;

namespace mappers
{
    public static partial class InnerModelMapper
    {
        public static InnerDto AdaptToInnerDto(this InnerModel p1)
        {
            return p1 == null ? null : new InnerDto() {Id = p1.Id};
        }
    }
}