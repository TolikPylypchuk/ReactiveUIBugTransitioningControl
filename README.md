# ReactiveUI Bug with TransitioningContentControl Reproduction

This is a simple WPF repository for reproducing a bug in ReactiveUI 12.1.1.

When a `TransitioningContentControl`'s initial actual width or height is 0, it throws an exception.
