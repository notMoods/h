interface ICovariant<out T> { }

interface IInvariant<T> : ICovariant<T> { }         //it is invariant because it was not specified

interface IExtCovariant<out T> : ICovariant<T> { } //here it is covariant


interface ICovariant2<out T> { }    //covariant
interface IContravariant2<in T> { } //contravariant
interface IInvariant2<T> : ICovariant2<T>, IContravariant2<T> { }  //combines both



interface ICovariant3<out T> { }
// The following statement generates a compiler error.
// interface ICoContraVariant<in T> : ICovariant3<T> { }