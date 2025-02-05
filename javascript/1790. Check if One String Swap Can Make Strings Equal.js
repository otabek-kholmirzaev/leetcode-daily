var areAlmostEqual = function (s1, s2) {
  let x = -1,
    y = -1;
  let count = 0;
  for (let i = 0; i < s1.length; i++) {
    if (s1[i] != s2[i]) {
      count++;
      if (x == -1) x = i;
      else if (y == -1) y = i;
    }
  }

  if (count >= 3 || count == 1) return false;
  if (count == 0) return true;
  // count == 2
  return s1[x] == s2[y] && s1[y] == s2[x];
};
