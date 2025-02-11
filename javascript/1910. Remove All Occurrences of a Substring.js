/**
 * @param {string} s
 * @param {string} part
 * @return {string}
 */
var removeOccurrences = function (s, part) {
  while (true) {
    let i = s.indexOf(part);
    if (i == -1) break;
    s = s.slice(0, i) + s.slice(i + part.length);
  }

  return s;
};
