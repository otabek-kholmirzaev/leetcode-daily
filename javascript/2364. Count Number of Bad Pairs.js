/**
 * @param {number[]} nums
 * @return {number}
 */
var countBadPairs = function (nums) {
  let ans = 0;
  let map = new Map();
  for (let i = 0; i < nums.length; i++) {
    let val = i - nums[i];
    if (map.has(val)) {
      ans += i - map.get(val);
      map.set(val, map.get(val) + 1);
    } else {
      ans += i;
      map.set(val, 1);
    }
  }

  return ans;
};
