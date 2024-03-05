#pragma once

#include <glm/glm.hpp>

class Shader {
public:
	unsigned int ID;

	Shader(const char* vertexPath, const char* fragmentPath);
	~Shader();
	void use() const;
	void setFloat(const char* name, float value) const;
	void setSampler(const char* name, unsigned int unit) const;
	void setMat4(const char* name, const glm::mat4& mat) const;
};