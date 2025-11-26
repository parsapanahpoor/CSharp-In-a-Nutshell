# Finalizers - Quick Review

## Definition
A finalizer (or destructor) is a special method called by the Garbage Collector before freeing an object's memory. It is defined with `~ClassName()` syntax and used to cleanup unmanaged resources.

## Usage
- Releasing unmanaged resources (file handles, network connections, native memory)
- Cleanup in classes without IDisposable
- Safety net for cases where Dispose is not called
- Writing defensive code for resource management
- Working with native interop and P/Invoke

## Key Points
- **Syntax**: `~ClassName() { }` - similar to C++ destructor
- **Non-Deterministic**: Exact execution time is uncertain (determined by GC)
- **No Parameters**: Cannot have parameters
- **No Access Modifier**: Cannot have access modifier
- **No Overloading**: Only one finalizer per class
- **Performance Impact**: Reduces GC performance (promoted to next generation)
- **Finalization Queue**: Objects with finalizer are placed in finalization queue
- **Gen2**: Causes object promotion to Generation 2
- **IDisposable Pattern**: Should be implemented alongside IDisposable
- **SafeHandle**: Better alternative for most scenarios
- **GC.SuppressFinalize**: Should be called in Dispose
- **No Inheritance**: Cannot have in struct
- **Exception Handling**: Exception in finalizer is dangerous
- **Avoid**: Should not be used in most cases
- **Resource Cleanup**: Only for unmanaged resources
