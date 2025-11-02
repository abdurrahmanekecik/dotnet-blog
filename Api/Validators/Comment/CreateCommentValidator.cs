using Api.Models.Comment;
using FluentValidation;

namespace Api.Validators
{
    public class CreateCommentValidator : AbstractValidator<CreateCommentRequest>
    {
        public CreateCommentValidator()
        {
            RuleFor(x => x.Content)
                .NotEmpty()
                .WithMessage("Yorum içeriği boş olamaz.")
                .MaximumLength(500);

            RuleFor(x => x.PostId).NotEmpty().WithMessage("PostId zorunludur.");
        }
    }
}
