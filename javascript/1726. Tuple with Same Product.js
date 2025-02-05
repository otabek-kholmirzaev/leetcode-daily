var tupleSameProduct = function (nums) {
  let n = nums.length;
  let map = new Map();
  for (let i = 0; i < n; i++) {
    for (let j = i + 1; j < n; j++) {
      let res = nums[i] * nums[j];
      map.set(res, (map.get(res) ?? 0) + 1);
    }
  }

  let ans = 0;
  for (let [, val] of map) {
    ans += val * (val - 1) * 4;
  }

  return ans;
};
