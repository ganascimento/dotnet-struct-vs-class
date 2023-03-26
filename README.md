# Dotnet Struct vs Class

## About

This project was developed to test differences in performance between struct and class.
Some struct implementation was used to test the performance.
See the results below:

### ExecClass

```
607 MB
Time: 128 ms
GC Gen0: 0
```

### ExecStructV1

```
257 MB
Time: 2809 ms
GC Gen0: 182
```

### ExecStructV2

```
257 MB
Time: 156 ms
GC Gen0: 39
```

### ExecStructV3

```
245 MB.
Time: 57 ms
GC Gen0: 1
```

## But why?

Structs are allocated on the stack, are "Value Types" while the class are allocated on the heap, and are "Reference Types"

In the test "ExecStructV1" see the memory reduction 257MB against 607MB using class, but the execution time is much higher, this is due to standard comparison in Structs using reflaction, and it uses many garbage collectors.

In the test "ExecStructV2" see that the memory reduction is equals to "ExecStructV1", but the execution time is much less, but trigger the garbage collector many times, this is because override equals using an instance of "object" to the casting and allocate the instance of "CoordinatesStructV2" in the heap memory.

In the test "ExecStructV3" when using an "IEquatable" interface, this interface allows you to specify which object o use to compare.

## When use struct?

Struct can be used in cases where you are going to create a simple and immutable object, for example when you are going to create a DTO in the API
