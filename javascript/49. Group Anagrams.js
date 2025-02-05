var groupAnagrams = function (strs) {
  let map = new Map();
  for (let s of strs) {
    let a = [...s].sort().join("");

    if (map.has(a)) map.get(a).push(s);
    else map.set(a, [s]);

    console.log(a, map.get(a));
  }

  let ans = [];
  for (let [, val] of map) {
    ans.push(val);
  }

  return ans;
};
