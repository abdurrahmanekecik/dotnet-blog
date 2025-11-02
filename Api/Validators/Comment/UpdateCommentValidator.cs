using Api.Models.Comment;
using FluentValidation;

namespace Api.Validators.Comment
{
    public class UpdateCommentValidator : AbstractValidator<UpdateCommentRequest>
    {
        public UpdateCommentValidator()
        {
            RuleFor(x => x.Uuid).NotEmpty().WithMessage("Uuid boş olamaz.");

            RuleFor(x => x.Content)
                .NotEmpty()
                .WithMessage("Yorum içeriği boş olamaz.")
                .MaximumLength(500);
        }
    }
}
