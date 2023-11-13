<template>
  <div>
      <h1 class="mt-4">Staff</h1>
      <p class="mt-2 mb-4">(Interdisciplinary Youth Innovation Team of Jilin University, 吉林大学学科交叉青年创新团队)</p>
      <p class="mt-2 mb-4">(Key Laboratory of Ancient Chinese Script, Culture relics and Artificial Intelligence, Jilin Province,  吉林大学古文字古文物人工智能实验室)</p>
      <v-row>
        <v-col cols="2">
          <div>
              <v-img :src="photo1" style="border-radius:100%;max-height:230px"></v-img>
          </div>
        </v-col>
        <v-col cols="4">
          <div class="mt-1">
            <h2 class="mb-2">{{name1}}</h2>
            <p v-for="t in titles1" :key="t">{{t}}</p>
            <a :href="homepage1">Homepage</a>
            <h4 class="mb-2 mt-1">Research Interests</h4>
            <ul>
                <li v-for="t in researchInterests1" :key="t">{{t}}</li>
            </ul>
          </div>
        </v-col>
        <v-col cols="2">
          <div>
              <v-img :src="photo2" style="border-radius:100%;max-height:230px"></v-img>
          </div>
        </v-col>
        <v-col cols="3">
          <div class="mt-1">
            <h2 class="mb-2">{{name2}}</h2>
            <p v-for="t in titles2" :key="t">{{t}}</p>
            <a :href="homepage2">Homepage</a>
            <h4 class="mb-2 mt-1">Research Interests</h4>
            <ul>
                <li v-for="t in researchInterests2" :key="t">{{t}}</li>
            </ul>
          </div>
        </v-col>
      </v-row>
  </div>
</template>

<script>
export default {
  data: () => ({
    name1: 'Xi Yang (杨溪)',
    homepage1: 'https://keepthinkingyx.github.io/Xi-Yang/',
    titles1: ['Associate Professor', 'School of Artificial Intelligence, Jilin University'],
    researchInterests1: ['Computer graphics', 'Deep learning', 'Human–computer interaction'],
    photo1: 'img/yangxi.png',
    name2: 'Chuntao Li (李春桃)',
    homepage2: 'https://gujisuo.jlu.edu.cn/info/1032/1156.htm',
    titles2: ['Professor', 'School of Archaeology, Jilin University'],
    researchInterests2: ['Paleography', 'Historical Philology'],
    photo2: 'img/lichuntao.jpeg'
  })
}
</script>
