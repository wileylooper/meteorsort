public static void MeteorSort(int[] elements) {
  int elementsCount = elements.Length;
  int element;
  int gap = elementsCount;
  int i;
  int j;

  while (gap > 15) {
    gap = ((gap >> 2) - (gap >> 4)) + (gap >> 3);
    i = gap;

    while (i < elementsCount) {
      element = elements[i];
      j = i;

      while (
        j >= gap &&
        elements[j - gap] > element
      ) {
        elements[j] = elements[j - gap];
        j -= gap;
      }

      elements[j] = element;
      i++;
    }
  }

  i = 1;
  gap = 0;

  while (i < elementsCount) {
    element = elements[i];
    j = i;

    while (
      j > 0 &&
      elements[gap] > element
    ) {
      elements[j] = elements[gap];
      j = gap;
      gap--;
    }

    elements[j] = element;
    gap = i;
    i++;
  }
}
