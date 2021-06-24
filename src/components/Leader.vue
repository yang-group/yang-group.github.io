<template>
  <div>
      <h1>Staff</h1>
      <v-row>
        <v-col cols="2">
          <div>
              <v-img :src="photo" style="border-radius:100%"></v-img>
          </div>
        </v-col>
        <v-col cols="3">
          <div class="mt-1">
            <h2 class="mb-2">{{name}}</h2>
            <p v-for="t in titles" :key="t">{{t}}</p>
            <a :href="homepage">Homepage</a>
            <h4 class="mb-2 mt-3">Research Interests</h4>
            <ul>
                <li v-for="t in researchInterests" :key="t">{{t}}</li>
            </ul>
          </div>
        </v-col>
      </v-row>
  </div>
</template>

<script>
export default {
  data: () => ({
    name: 'Xi Yang (杨溪)',
    homepage: 'https://keepthinkingyx.github.io/Xi-Yang/',
    titles: ['Associate Professor', 'School of Artificial Intelligence, Jilin University'],
    researchInterests: ['Computer graphics', 'Deep learning', 'Human–computer interaction'],
    photo: 'img/yangxi.png'
  })
}
</script>
