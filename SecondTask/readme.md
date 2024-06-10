# Main idea

We start with `Operation` that can't be translated into any number
(it represents some kind of not-ended equation).
But `Operation` has every number from witch you can start.

After calling any getter from `Operation` you receive a `Value` entity.
Entity is _implicitly_ converted into `double` if you use it for such purposes.

The `Value` has it's own getters, the `Operation` ones. So you can continue 
manipulating the number with them.

With this approach user just **can't** use wrong commands in code. 

Safe and clean.
