#### MeteorSort

MeteorSort provides enhanced speed as an ideal alternative to a vast majority of sorting algorithm implementations that don't require sorting stability, including all Shell Sort gap sequences.

It's an in-place, unstable sorting algorithm that doesn't allocate memory for auxiliary subarrays or gap constants.

It's up to 3x faster than `Array.Sort` for arrays of all sizes with with mostly-sorted, sorted and unsorted distributions.

`MeteorSort` sorts an array of elements in ascending order, provided the integral data type of each element in `elements` matches `element`.
