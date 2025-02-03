var levelOrder = function (root) {
  if (root === null) return [];
  let ans = [];
  let queue = [root];
  while (queue.length > 0) {
    let level = [];
    let length = queue.length;
    for (let i = 0; i < length; i++) {
      let cur = queue.shift();
      level.push(cur.val);
      if (cur.left !== null) queue.push(cur.left);
      if (cur.right !== null) queue.push(cur.right);
    }

    ans.push(level);
  }

  return ans;
};
